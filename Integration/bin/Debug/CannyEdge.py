import clr
clr.AddReference('System.Windows.Forms')
clr.AddReference('System.Drawing')
from System.Windows.Forms import*
from System.Drawing import *
from array import *
from math import*

def CannyEdge_Click(sender,args):   
    image = Bitmap(sender.Tag.pictureBox.Image)
    sender.Tag.label.Text = "Canny Edge Detection"
    sender.Tag.bottomLabel.Text = "Lower"
    sender.Tag.upLabel.Text = "Upper"
    upperTh = float(sender.Tag.txtBoxFactor2.Text)
    if upperTh > 150:
        upperTh = 150
    LowerTh = float(sender.Tag.txtBoxFactor1.Text)
    if LowerTh < 50:
        LowerTh = 50
    pixelIn = Color()
    copy = image
    height = copy.Height
    width = copy.Width
    Blur = [[1,2,1],[2,4,2],[1,2,1]]
    matrixX = [[-1,0,1],[-2,0,2],[-1,0,1]] 
    matrixY = [[1,2,1],[0,0,0],[-1,-2,-1]]
    blurImage = GetBlurImage(copy,Blur)
    print("Final Conversion Begin")
    FinalImage = Bitmap(width,height)
    FinalImage = GetCannyEdge(blurImage,matrixX,matrixY,upperTh,LowerTh)
    print("Final Conversion Complete")
    sender.Tag.pictureBoxPy.Image = FinalImage


def GetBlurImage(receivedImage,Kernelmatrix):
    KernelSum = 0
    height = receivedImage.Height
    width = receivedImage.Width
    newImage= Bitmap(width,height)
    pixGray = [[0,0,0],[0,0,0],[0,0,0]] 
    for p in range (0,3):
                for q in range (0,3):
                    KernelSum = KernelSum + Kernelmatrix [p][q]
    for i in range (1,width-1):
        for j in range (1,height-1):            
            for p in range (-1,2):
                for q in range (-1,2):                    
                    pixelIn = receivedImage.GetPixel(i+p,j+q)
                    pixGray[p+1][q+1] = (0.299 * pixelIn.R + 0.578 * pixelIn.G + 0.114 * pixelIn.B)
            sumPix = 0
            for p in range (0,3):
                for q in range (0,3):                    
                    sumPix = sumPix + (pixGray[p][q]* Kernelmatrix [p][q])
            if KernelSum > 0:
                sumPix = sumPix/KernelSum
            if sumPix < 0:
                sumPix = 0
            if sumPix > 255: 
                sumPix = 255
            newImage.SetPixel(i, j, Color.FromArgb(sumPix, sumPix, sumPix))
    return newImage


def GetCannyEdge(receivedImage,KMatX,KMatY,Up,Lower):
    KMatSumX = 0
    KMatSumY = 0
    height = receivedImage.Height
    width = receivedImage.Width
    newImage = Bitmap(width,height)
    pixGray = [[0,0,0],[0,0,0],[0,0,0]] 
    for p in range (0,3):
        for q in range (0,3):
            KMatSumX = KMatSumX + KMatX [p][q]
            KMatSumY = KMatSumY + KMatY [p][q]
    for i in range (1,width-1):
        for j in range (1,height-1):            
            for p in range (-1,2):
                for q in range (-1,2):                    
                    pixelIn = receivedImage.GetPixel(i+p,j+q)
                    pixGray[p+1][q+1] = pixelIn.R
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
            if(r > Lower and r < Up):
                newImage.SetPixel(i, j, Color.FromArgb(255, 255, 255))
            else:
                newImage.SetPixel(i, j, Color.FromArgb(0,0,0))
    return newImage
