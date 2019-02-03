using SwfExtractor;
using SwfExtractor.Tags;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MochiCryptUnpacker
{
    public partial class frmMain : Form
    {
        private void Log(string str)
        {
            txtLog.Text += $"{str}\r\n";
            txtLog.SelectionStart = txtLog.Text.Length - 1;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            bool fail = false;
            txtLog.Text = null;
            foreach(string file in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                FileInfo fi = new FileInfo(file);
                byte[] data = File.ReadAllBytes(file);
                SwfParser swf = new SwfParser();
                try
                {
                    swf.Parse(data);
                }
                catch
                {
                    Log($"->{fi.Name} 不是有效的 SWF 文件 (Invalid SWF)");
                    continue;
                }
                try
                {
                    DefineBinaryData payloadTag = swf.FindTags<DefineBinaryData>().ToList().Find(i => i.CharacterID == 7);
                    byte[] payload = payloadTag.ExtractData();
                    byte[] decrypted = MochiDecrypt.Decrypt(payload);
                    File.WriteAllBytes($"{fi.DirectoryName}\\{Path.GetFileNameWithoutExtension(fi.Name)}_Unpacked.swf", decrypted);
                    Log($"->{fi.Name} 解密成功 (Success)");
                }
                catch
                {
                    Log($"->{fi.Name} 解密失败 (Failed)");
                    fail = true;
                    continue;
                }
            }
            if (fail)
                Log($"\r\n存在解密失败的文件, 可能不是 MochiCrypt 加密的文件, 或 MochiCrypt 版本有更新");
        }

        private void LlbAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmAbout().ShowDialog();
        }
    }
}
