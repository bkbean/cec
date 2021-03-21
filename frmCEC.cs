using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CEC
{
    public partial class frmCEC : Form
    {
        private FileMode fileMode = FileMode.File;

        public frmCEC()
        {
            InitializeComponent();
        }

        private void miFileModeFile_CheckedChanged(object sender, EventArgs e)
        {
            if (miFileModeFile.Checked)
            {
                fileMode = FileMode.File;
                miFileModeFolder.Checked = false;
                grpPreview.Enabled = true;
                chkPreviewSrc.Checked = true;
            }
        }

        private void miFileModeFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (miFileModeFolder.Checked)
            {
                fileMode = FileMode.Folder;
                miFileModeFile.Checked = false;
                grpPreview.Enabled = false;
            }
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            if (!PathExist(txtConversionPath.Text))
            {
                return;
            }
            
            string str = string.Empty;
            str = cmbConversionFrom.Text;
            Encoding srcEncoding = Encoding.GetEncoding(int.Parse(
                str.Substring(
                str.LastIndexOf(':') + 1,
                str.Length - str.LastIndexOf(':') - 2)));

            str = cmbConversionTo.Text;
            Encoding dstEncoding = Encoding.GetEncoding(int.Parse(
                str.Substring(
                str.LastIndexOf(':') + 1,
                str.Length - str.LastIndexOf(':') - 2)));

            if (FileMode.File == fileMode)
            {
                ConvertFile(txtConversionPath.Text, srcEncoding, dstEncoding, chkMakeNewFile.Checked);
            }
            else
            {
                ConvertDirectory(txtConversionPath.Text, srcEncoding, dstEncoding, chkMakeNewFile.Checked);
            }
        }

        private void frmCEC_Load(object sender, EventArgs e)
        {
            miFileModeFile.Checked = true;
            miFileModeFolder.Checked = false;
            miFileCodePageCommon.Checked = true;
            miFileCodePageAll.Checked = false;
            SetCodePageList(CodePageList.Common);
            chkGb2312SToBig5.Checked = false;
            chkBig5ToGb2312S.Checked = false;

            grpPreview.Enabled = true;
            chkPreviewSrc.Checked = true;
            btnPreview.Enabled = true;
        }

        private void btnConversionPathBrowser_Click(object sender, EventArgs e)
        {
            string strConversionPath = string.Empty;

            if (FileMode.File == fileMode)
            {
                ofdlgConversionPath.ShowDialog();
                strConversionPath = ofdlgConversionPath.FileName;
            }
            else
            {
                fbdlgConversionPath.ShowDialog();
                strConversionPath = fbdlgConversionPath.SelectedPath;
            }

            txtConversionPath.Text = strConversionPath;
        }

        private bool ConvertFile(string fileName, Encoding srcEncoding, Encoding dstEncoding, bool newfile)
        {
            string dstFileName = fileName;
            if (newfile)
            {
                FileInfo fi = new FileInfo(fileName);
                if(fi.Extension.Equals(string.Empty))
                {
                    dstFileName = fileName + "_cec";
                }
                else
                {
                    dstFileName = fileName.Substring(0, fileName.LastIndexOf('.')) + "_cec.txt";
                }
            }

            StreamReader sr = new StreamReader(fileName, srcEncoding);
            string strContent = sr.ReadToEnd();
            sr.Close();

            if (srcEncoding.CodePage == 936 && dstEncoding.CodePage == 950)
            {
                strContent = ConvertString.Gb2312SToBig5(strContent);
            }
            else if (srcEncoding.CodePage == 950 && dstEncoding.CodePage == 936)
            {
                strContent = ConvertString.Big5ToGb2312S(strContent);
            }

            StreamWriter sw = new StreamWriter(dstFileName, false, dstEncoding);
            sw.Write(strContent);
            sw.Close();
            return true;
        }

        private bool ConvertDirectory(string path, Encoding srcEncoding, Encoding dstEncoding, bool newfile)
        {
            DirectoryInfo FatherDirectory = new DirectoryInfo(path);
            FileInfo[] NewFileInfo;
            DirectoryInfo[] ChildDirectory;

            NewFileInfo = FatherDirectory.GetFiles();
            foreach (FileInfo fileInfo in NewFileInfo)
            {
                ConvertFile(fileInfo.FullName, srcEncoding, dstEncoding, newfile);
            }

            ChildDirectory = FatherDirectory.GetDirectories();
            foreach (DirectoryInfo dirInfo in ChildDirectory)
            {
                ConvertDirectory(dirInfo.FullName, srcEncoding, dstEncoding, newfile);
            }

            return true;
        }

        private void miFileCodePageAll_CheckedChanged(object sender, EventArgs e)
        {
            if (miFileCodePageAll.Checked)
            {
                miFileCodePageCommon.Checked = false;
                miFileCodePageCJK.Checked = false;

                SetCodePageList(CodePageList.All);
            }
        }

        private void miFileCodePageCommon_CheckedChanged(object sender, EventArgs e)
        {
            if (miFileCodePageCommon.Checked)
            {
                miFileCodePageAll.Checked = false;
                miFileCodePageCJK.Checked = false;

                SetCodePageList(CodePageList.Common);
            }
        }

        private void miFileCodePageCJK_CheckedChanged(object sender, EventArgs e)
        {
            if (miFileCodePageCJK.Checked)
            {
                miFileCodePageAll.Checked = false;
                miFileCodePageCommon.Checked = false;

                SetCodePageList(CodePageList.CJK);
            }
        }

        private void miFileExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void chkGb2312SToBig5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGb2312SToBig5.Checked)
            {
                miFileCodePageCJK.Checked = true;
                miFileCodePageCJK_CheckedChanged(null, null);

                chkBig5ToGb2312S.Checked = false;
                cmbConversionFrom.Text = Encoding.GetEncoding(936).EncodingName + " [CP:936]";
                cmbConversionTo.Text = Encoding.GetEncoding(950).EncodingName + " [CP:950]";
            }

            cmbConversionFrom.Enabled = !(chkGb2312SToBig5.Checked || chkBig5ToGb2312S.Checked);
            cmbConversionTo.Enabled = !(chkGb2312SToBig5.Checked || chkBig5ToGb2312S.Checked);
        }

        private void chkBig5ToGb2312S_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBig5ToGb2312S.Checked)
            {
                miFileCodePageCJK.Checked = true;
                miFileCodePageCJK_CheckedChanged(null, null);

                chkGb2312SToBig5.Checked = false;
                cmbConversionFrom.Text = Encoding.GetEncoding(950).EncodingName + " [CP:950]";
                cmbConversionTo.Text = Encoding.GetEncoding(936).EncodingName + " [CP:936]";
            }
            
            cmbConversionFrom.Enabled = !(chkGb2312SToBig5.Checked || chkBig5ToGb2312S.Checked);
            cmbConversionTo.Enabled = !(chkGb2312SToBig5.Checked || chkBig5ToGb2312S.Checked);
        }

        private bool PathExist(string path)
        {
            if (path.Equals(string.Empty))
            {
                MessageBox.Show("Please input the path.", "Info");
                return false;
            }

            if (0 == fileMode)
            {
                FileInfo fi = null;

                try
                {
                    fi = new FileInfo(path);
                }
                catch
                {
                    MessageBox.Show("The format of filename was wrong.", "Info");
                    return false;
                }

                if (!fi.Exists)
                {
                    MessageBox.Show("The file was not found.", "Info");
                    return false;
                }
            }
            else
            {
                DirectoryInfo di = null;

                try
                {
                    di = new DirectoryInfo(path);
                }
                catch
                {
                    MessageBox.Show("The format of path name was wrong.", "Info");
                    return false;
                }

                if (!di.Exists)
                {
                    MessageBox.Show("The path was not found.", "Info");
                    return false;
                }
            }

            return true;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (!PathExist(txtConversionPath.Text))
            {
                return;
            }

            string str = string.Empty;
            str = cmbConversionFrom.Text;
            Encoding srcEncoding = Encoding.GetEncoding(int.Parse(
                str.Substring(
                str.LastIndexOf(':') + 1,
                str.Length - str.LastIndexOf(':') - 2)));

            str = cmbConversionTo.Text;
            Encoding dstEncoding = Encoding.GetEncoding(int.Parse(
                str.Substring(
                str.LastIndexOf(':') + 1,
                str.Length - str.LastIndexOf(':') - 2)));

            string content = string.Empty;
            char[] buff = new char[300];

            StreamReader sr = new StreamReader(txtConversionPath.Text,srcEncoding);
            sr.Read(buff, 0, 300);
            sr.Close();

            byte[] srcContent = srcEncoding.GetBytes(buff);
            content = srcEncoding.GetString(srcContent);

            if (chkPreviewSrc.Checked)
            {
                frmPreview preview = new frmPreview(srcEncoding.EncodingName + " [CP:" + srcEncoding.CodePage + "]", content);
                preview.Show();
            }

            if (chkPreviewDst.Checked)
            {
                if (srcEncoding.CodePage == 936 && dstEncoding.CodePage == 950)
                {
                    content = ConvertString.Gb2312SToBig5(content);
                }
                else if (srcEncoding.CodePage == 950 && dstEncoding.CodePage == 936)
                {
                    content = ConvertString.Big5ToGb2312S(content);
                }
                else
                {
                    byte[] dstContent = Encoding.Convert(srcEncoding, dstEncoding, srcContent);
                    content = dstEncoding.GetString(dstContent);
                }

                frmPreview preview = new frmPreview(dstEncoding.EncodingName + " [CP:" + dstEncoding.CodePage + "]", content);
                preview.Show();
            }
        }

        private bool SetCodePageList(CodePageList type)
        {
            EncodingInfo[] eis = null;

            switch (type)
            {
                case CodePageList.Common:
                    cmbConversionFrom.Items.Clear();
                    cmbConversionFrom.Items.Add("ASCII [CP:" + Encoding.ASCII.CodePage + "]");
                    cmbConversionFrom.Items.Add("BigEndianUnicode [CP:" + Encoding.BigEndianUnicode.CodePage + "]");
                    cmbConversionFrom.Items.Add("Default [CP:" + Encoding.Default.CodePage + "]");
                    cmbConversionFrom.Items.Add("Unicode [CP:" + Encoding.Unicode.CodePage + "]");
                    cmbConversionFrom.Items.Add("UTF32 [CP:" + Encoding.UTF32.CodePage + "]");
                    cmbConversionFrom.Items.Add("UTF7 [CP:" + Encoding.UTF7.CodePage + "]");
                    cmbConversionFrom.Items.Add("UTF8 [CP:" + Encoding.UTF8.CodePage + "]");
                    cmbConversionFrom.Text = cmbConversionFrom.Items[0].ToString();

                    cmbConversionTo.Items.Clear();
                    cmbConversionTo.Items.Add("ASCII [CP:" + Encoding.ASCII.CodePage + "]");
                    cmbConversionTo.Items.Add("BigEndianUnicode [CP:" + Encoding.BigEndianUnicode.CodePage + "]");
                    cmbConversionTo.Items.Add("Default [CP:" + Encoding.Default.CodePage + "]");
                    cmbConversionTo.Items.Add("Unicode [CP:" + Encoding.Unicode.CodePage + "]");
                    cmbConversionTo.Items.Add("UTF32 [CP:" + Encoding.UTF32.CodePage + "]");
                    cmbConversionTo.Items.Add("UTF7 [CP:" + Encoding.UTF7.CodePage + "]");
                    cmbConversionTo.Items.Add("UTF8 [CP:" + Encoding.UTF8.CodePage + "]");
                    cmbConversionTo.Text = cmbConversionFrom.Items[0].ToString(); break;

                case CodePageList.CJK:
                    cmbConversionFrom.Items.Clear();
                    cmbConversionTo.Items.Clear();

                    eis = Encoding.GetEncodings();
                    foreach (EncodingInfo ei in eis)
                    {
                        if ((ei.CodePage == Encoding.Default.CodePage)
                            || ei.DisplayName.ToLower().Contains("gb")
                            || ei.DisplayName.ToLower().Contains("big5")
                            || ei.DisplayName.ToLower().Contains("unicode")
                            || ei.DisplayName.ToLower().Contains("utf"))
                        {
                            cmbConversionFrom.Items.Add(ei.DisplayName + " [CP:" + ei.CodePage + "]");
                            cmbConversionTo.Items.Add(ei.DisplayName + " [CP:" + ei.CodePage + "]");
                        }
                    }

                    if (cmbConversionFrom.Items.Count > 0
                        && cmbConversionTo.Items.Count > 0)
                    {
                        cmbConversionFrom.Text = cmbConversionFrom.Items[0].ToString();
                        cmbConversionTo.Text = cmbConversionFrom.Items[0].ToString();
                    }
                    break;

                case CodePageList.All:
                    cmbConversionFrom.Items.Clear();
                    cmbConversionTo.Items.Clear();

                    eis = Encoding.GetEncodings();
                    foreach (EncodingInfo ei in eis)
                    {
                        cmbConversionFrom.Items.Add(ei.DisplayName + " [CP:" + ei.CodePage + "]");
                        cmbConversionTo.Items.Add(ei.DisplayName + " [CP:" + ei.CodePage + "]");
                    }

                    if (cmbConversionFrom.Items.Count > 0
                        && cmbConversionTo.Items.Count > 0)
                    {
                        cmbConversionFrom.Text = cmbConversionFrom.Items[0].ToString();
                        cmbConversionTo.Text = cmbConversionFrom.Items[0].ToString();
                    }
                    break;

                default:
                    break;
            }

            return true;
        }

        private void chkPreviewSrc_CheckedChanged(object sender, EventArgs e)
        {
            btnPreview.Enabled = chkPreviewSrc.Checked || chkPreviewDst.Checked;
        }

        private void chkPreviewDst_CheckedChanged(object sender, EventArgs e)
        {
            btnPreview.Enabled = chkPreviewSrc.Checked || chkPreviewDst.Checked;
        }

        private void miHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void miHelpContents_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("help.chm");
            if (fi.Exists)
            {
                Help.ShowHelp(new Control(), "help.chm");
            }
        }
    }
}