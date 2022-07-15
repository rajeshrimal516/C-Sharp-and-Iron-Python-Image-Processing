import clr
clr.AddReference('System.Windows.Forms')
clr.AddReference('System.Drawing')
from System.Windows.Forms import*
from System.Drawing import *
from array import *
from math import*

def Sharpen_Click(sender,args):   
    image = Bitmap(sender.Tag.pictureBox.Image)
    sender.Tag.label.Text = "Sharpen Image"
    sender.Tag.bottomLabel.Text = ""
    sender.Tag.upLabel.Text = ""
    sender.Tag.txtBoxFactor2.Text=str(0)
    sender.Tag.txtBoxFactor1.Text=str(0)
    pixelIn = Color()
    copy = image
    height = copy.Height
    width = copy.Width
    Sharpen = [[-1,-1,-1],[-1,9,-1],[-1,-1,-1]]
    print("Final Conversion Begin")
    sharpImage = GetSharpImage(copy,Sharpen)
    print("Final Conversion Complete")
    sender.Tag.pictureBoxPy.Image = sharpImage

def GetSharpImage(receivedImage,Kernelmatrix):
    KernelSum = 0
    height = receivedImage.Height
    width = receivedImage.Width
    newImage= Bitmap(width,height)
    pixR = [[0,0,0],[0,0,0],[0,0,0]]
    pixG = [[0,0,0],[0,0,0],[0,0,0]] 
    pixB = [[0,0,0],[0,0,0],[0,0,0]]
    for p in range (0,3):
                for q in range (0,3):
                    KernelSum = KernelSum + Kernelmatrix [p][q]
    for i in range (1,width-1):
        for j in range (1,height-1):            
            for p in range (-1,2):
                for q in range (-1,2):                    
                    pixelIn = receivedImage.GetPixel(i+p,j+q)
                    pixR[p+1][q+1] = pixelIn.R
                    pixG[p+1][q+1] = pixelIn.G
                    pixB[p+1][q+1] = pixelIn.B
            sumR = 0
            sumG = 0
            sumB = 0
            for p in range (0,3):
                for q in range (0,3):                    
                    sumR = sumR + (pixR[p][q]* Kernelmatrix [p][q])
                    sumG = sumG + (pixG[p][q]* Kernelmatrix [p][q])
                    sumB = sumB + (pixB[p][q]* Kernelmatrix [p][q])
            if KernelSum > 0:
                sumR = sumR/KernelSum
                sumG = sumG/KernelSum
                sumB = sumB/KernelSum

            if sumR < 0:
                sumR = 0
            if sumR > 255: 
                sumR = 255
            if sumG < 0:
                sumG = 0
            if sumG > 255: 
                sumG = 255
            if sumB < 0:
                sumB = 0
            if sumB > 255: 
                sumB = 255
            newImage.SetPixel(i, j, Color.FromArgb(sumR, sumG, sumB))
    return newImage

