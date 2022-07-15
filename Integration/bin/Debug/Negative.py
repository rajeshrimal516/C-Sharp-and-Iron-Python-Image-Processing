import clr
clr.AddReference('System.Windows.Forms')
clr.AddReference('System.Drawing')

from System.Windows.Forms import*
from System.Windows.Forms import SaveFileDialog
from System.Drawing import *
from math import*
import array as arr

name='Negative'

def Negative_Click(sender,args):   
    image = Bitmap(sender.Tag.pictureBox.Image)
    sender.Tag.label.Text = "Negative Conversion"
    sender.Tag.txtBoxFactor1.Text=str(0)
    sender.Tag.txtBoxFactor2.Text=str(0)
    sender.Tag.bottomLabel.Text = ""
    sender.Tag.upLabel.Text = ""
    pixelIn = Color()
    copy = image
    height = copy.Height
    width = copy.Width    
    for i in range (0,width):
        for j in range (0,height):
            pixelIn = copy.GetPixel(i, j)
            r = 255 - pixelIn.R
            g = 255 - pixelIn.G
            b = 255 - pixelIn.B
            copy.SetPixel(i, j, Color.FromArgb(r, g, b))
    sender.Tag.pictureBoxPy.Image = copy
'''
def Load_PythonFiles(form):
    form.btnNegative.Click += Negative_Click
    form.btnNegative.Tag = form
    #form.btnSave.Click += Save_Click
    #form.btnSave.Tag = form'''
'''
def Save_Click(sender,args):
    sfile = SaveFileDialog()
    sfile.Filter = "Image Files (*.bmp,*.jpg,*.jpeg,*.png)| *.bmp;*.jpg;*.jpeg;*.png"
    if (sfile.ShowDialog() == DialogResult.OK):
         if (sfile.OpenFile()):
            editlImage = sender.Tag.pictureBoxPy.Image
            editlImage.Save(sfile.FileName)
'''
            
            



   										



