import clr
clr.AddReference('System.Windows.Forms')
clr.AddReference('System.Drawing')
from System.Windows.Forms import*
from System.Windows.Forms import SaveFileDialog
from System.Drawing import *
from array import *
from math import*

name='SobelEdge'
    
def SobelEdge_Click(sender,args):   
    image = Bitmap(sender.Tag.pictureBox.Image)
    sender.Tag.label.Text = "Sobel Edge Detection"
    sender.Tag.txtBoxFactor1.Text=str(0)
    sender.Tag.txtBoxFactor2.Text=str(0)
    sender.Tag.bottomLabel.Text = ""
    sender.Tag.upLabel.Text =""
    pixelIn = Color()
    copy = image
    height = copy.Height
    width = copy.Width
    matrixX = [[-1,0,1],[-2,0,2],[-1,0,1]] 
    matrixY = [[1,2,1],[0,0,0],[-1,-2,-1]]
    print("Final Conversion Begin")
    FinalImage = Bitmap(width,height)
    FinalImage = GetSobelEdge(copy,matrixX,matrixY)
    print("Final Conversion Complete")
    sender.Tag.pictureBoxPy.Image = FinalImage

def GetSobelEdge(receivedImage,KMatX,KMatY):
    KMatSumX = 0
    KMatSumY = 0
    pixGray = [[0,0,0],[0,0,0],[0,0,0]]
    height = receivedImage.Height
    width = receivedImage.Width
    newImage = Bitmap(width,height)

    for p in range (0,3):
                for q in range (0,3):
                    KMatSumX = KMatSumX + KMatX [p][q]
                    KMatSumY = KMatSumY + KMatY [p][q]
    for i in range (1,width-1):
        for j in range (1,height-1):            
            for p in range (-1,2):
                for q in range (-1,2):                    
                    pixelIn = receivedImage.GetPixel(i+p,j+q)
                    pixGray[p+1][q+1] = (0.299 * pixelIn.R + 0.578 * pixelIn.G + 0.114 * pixelIn.B)
            sumPixX = 0
            sumPixY = 0
            for p in range (0,3):
                for q in range (0,3):                    
                    sumPixX = sumPixX + (pixGray[p][q]* KMatX [p][q])
                    sumPixY = sumPixY + (pixGray[p][q]* KMatY [p][q])
            if sumPixX < 0:
                sumPixX = 0
            if sumPixX > 255: 
                sumPixX = 255
            if sumPixY < 0:
                sumPixY = 0
            if sumPixY > 255: 
                sumPixY = 255
            r = sqrt(sumPixX**2 +  sumPixY**2)
            if r > 255:
                r = 255
            if r < 0:
                r = 0

            newImage.SetPixel(i, j, Color.FromArgb(r, r, r))
    return newImage