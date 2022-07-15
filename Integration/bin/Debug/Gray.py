import clr
clr.AddReference('System.Windows.Forms')
clr.AddReference('System.Drawing')
from System.Windows.Forms import*
from System.Drawing import *
from math import*
from array import *

name='Gray'
def Gray_Click(sender, args):
    sender.Tag.label.Text = "Grayscale Image"
    sender.Tag.txtBoxFactor1.Text=str(0)
    sender.Tag.txtBoxFactor2.Text=str(0)
    sender.Tag.bottomLabel.Text = ""
    sender.Tag.upLabel.Text = ""
    sender.Tag.pictureBoxPy.Image = Bitmap(sender.Tag.pictureBox.Image)
    image = Bitmap(sender.Tag.pictureBox.Image)
    pixelIn = Color()
    copy = image
    height = copy.Height
    width = copy.Width
    for i in range (0,width):
        for j in range (0,height):
            pixelIn = copy.GetPixel(i, j)
            r = (0.299 *pixelIn.R + 0.587 *pixelIn.G + 0.114 *pixelIn.B)
            if r > 255: 
                r = 255
            if r < 0:
                r = 0
            copy.SetPixel(i, j, Color.FromArgb(r, r, r))
    sender.Tag.pictureBoxPy.Image = copy 




    