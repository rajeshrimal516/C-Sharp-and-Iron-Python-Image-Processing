using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;
using IronPython.Hosting;           //Access to IronPython interpreter      
using IronPython.Runtime;           //Access to IronPython data types    
using Microsoft.Scripting;          //DLR support      
using Microsoft.Scripting.Hosting;  //DLR support

namespace Integration
{
    public partial class Form1 : Form
    {
        ScriptEngine pyEngine = null;
        ScriptScope pyScope = null;
        public Form1()
        {
            InitializeComponent();

            pyEngine = Python.CreateEngine();
            pyScope = pyEngine.CreateScope();
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image Files (*.bmp,*.jpg,*.jpeg,*.png)| *.bmp;*.jpg;*.jpeg;*.png";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.pictureBox.Image = new Bitmap(ofile.FileName);
                this.label.Text = "Original Image Loaded";
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBoxPy.Image != null)
            {
                SaveFileDialog sFile = new SaveFileDialog();
                sFile.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sFile.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBoxPy.Image.Save(sFile.FileName, format);
                    MessageBox.Show("Image Saved Successfully", sFile.FileName);
                }
            }
            else if (pictureBox.Image != null)
            {
                SaveFileDialog sFile = new SaveFileDialog();
                sFile.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sFile.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox.Image.Save(sFile.FileName, format);
                    MessageBox.Show ("Image Saved Successfully", sFile.FileName);
                }
            }
            else
            {
                MessageBox.Show("No File to Save");    
            }
        }

        private void LoadExtension_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog extensionFile = new OpenFileDialog())      
            {
                extensionFile.InitialDirectory = "Debug";
                extensionFile.Filter = "Python files (*.py)|*.py";

                if (extensionFile.ShowDialog() == DialogResult.OK)
                {
                    var fileName = System.IO.Path.GetFileName(extensionFile.FileName);
                    if (System.IO.File.Exists(fileName))                                
                    {
                        var scriptSourceObj = pyEngine.CreateScriptSourceFromFile(fileName);
                        scriptSourceObj.Execute(pyScope);
                        dynamic addExtensions = pyScope.GetVariable("Load_PythonFiles");
                        addExtensions(this);
                        this.label.Text = "Py Modules Loaded";
                    }
                    else   
                    {

                        using (var moduleFolder = new FolderBrowserDialog())
                        {
                            moduleFolder.Description = "Select the Module Folder path";
                            DialogResult moduleFolderCheck = moduleFolder.ShowDialog();

                            if (moduleFolderCheck == DialogResult.OK)
                            {
                                this.Text = extensionFile.FileName;
                                var debugFolder = new FolderBrowserDialog();
                                debugFolder.Description = "Select the Solution Debug Folder Path";
                                DialogResult resultdestination = debugFolder.ShowDialog();
                                System.IO.File.Copy(moduleFolder.SelectedPath + "\\" + fileName, debugFolder.SelectedPath + "\\" + fileName);
                                ScriptSource scriptSourceObj = pyEngine.CreateScriptSourceFromFile(fileName);
                                scriptSourceObj.Execute(pyScope);
                                dynamic addExtensions = pyScope.GetVariable("LoadExtension");
                                addExtensions(this);
                                this.label.Text = "Py Modules Loaded";
                            }
                        }

                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Image Processing";
            //this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
                
                
            
        }
    }
}
