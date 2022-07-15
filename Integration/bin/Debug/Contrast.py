import clr
clr.AddReference('System.Windows.Forms')
clr.AddReference('System.Drawing')
from System.Windows.Forms import*
from System.Drawing import *
from math import*
from array import *

name='Contrast'
def Contrast_Click(sender, args):
    sender.Tag.label.Text = "Enter Factor For Contrast Correction and Click Contrast (-100 to 100):"
    sender.Tag.txtBoxFactor2.Text=str(0)
    sender.Tag.bottomLabel.Text = "Factor"
    sender.Tag.upLabel.Text = ""
    factor = float(sender.Tag.txtBoxFactor1.Text)
    if factor < -100:
        factor = -100
    if factor > 100:
        factor = 100
    factor = (float)(259 * (255 + (factor))) / (255 * (259 - (factor)))
    sender.Tag.pictureBoxPy.Image = Bitmap(sender.Tag.pictureBox.Image)
    image = Bitmap(sender.Tag.pictureBox.Image)
    pixelIn = Color()
    copy = image
    height = copy.Height
    width = copy.Width

    for i in range (0,width):
        for j in range (0,height):
            pixelIn = copy.GetPixel(i, j)
            r = pixelIn.R * factor
            g = pixelIn.G * factor
            b = pixelIn.B * factor
            if r > 255: 
                r = 255
            if r < 0:
                r = 0
            if g > 255: 
                g = 255
            if g < 0:
                g = 0
            if b > 255: 
                b = 255
            if b < 0:
                b = 0
            copy.SetPixel(i, j, Color.FromArgb(r, g, b))         
    sender.Tag.pictureBoxPy.Image = copy 

def Load_PythonFiles(form):
    form.btnContrast.Click += Contrast_Click
    form.btnContrast.Tag=form
