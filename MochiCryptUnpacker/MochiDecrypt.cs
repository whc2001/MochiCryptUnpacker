using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Elskom.Generic.Libs;

namespace MochiCryptUnpacker
{
    public static class MochiDecrypt
    {
        public static byte[] Decrypt(byte[] payload)
        {
            List<byte> S = new List<byte>();
            int i = 0;
            int j = 0;
            int k = 0;
            int n = 0;
            int u = 0;
            int v = 0;

            n = payload.Length - 32;
            while (i < 256)
            {
                S.Add((byte)i);
                i++;
            }
            j = 0;
            i = 0;
            while (i < 256)
            {
                j = j + S[i] + payload[n + (i & 31)] & 255;
                u = S[i];
                S[i] = S[j];
                S[j] = (byte)u;
                i++;
            }
            if (n > 131072)
            {
                n = 131072;
            }
            j = 0;
            i = 0;
            k = 0;
            while (k < n)
            {
                i = i + 1 & 255;
                u = S[i];
                j = j + u & 255;
                v = S[j];
                S[i] = (byte)v;
                S[j] = (byte)u;
                payload[k] = (byte)(payload[k] ^ S[u + v & 255]);
                k++;
            }

            byte[] buf = new byte[65535];
            int lastDecompressed = 0;
            using (Stream input = new MemoryStream(payload))
            using (MemoryStream output = new MemoryStream())
            using (ZOutputStream zlib = new ZOutputStream(output))
            {
                do
                {
                    lastDecompressed = input.Read(buf, 0, buf.Length);
                    zlib.Write(buf, 0, lastDecompressed);
                    output.Flush();
                }
                while (lastDecompressed > 0);
                return output.ToArray();
            }
        }
    }
}
