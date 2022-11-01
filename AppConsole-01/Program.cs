using System.Drawing;

string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../Imagem/ponei.jpeg"));

int pixelsWidth = 300;

Image img = Bitmap.FromFile(path);

int pixelsHeigth = (int)(img.Height / (float)img.Width * pixelsWidth);

Bitmap imagem = new Bitmap(img, pixelsWidth, pixelsHeigth);

char[] charArr = { '1','.', '.', ',', ';', '-', 'L', 'U', 'H', '0', '#', '@' };


for(int i = 0; i< imagem.Height; i++)
{
    for(int j = 0; j< imagem.Width; j++)
    {
        Color c = imagem.GetPixel(j, i);
        byte grayScale = (byte)((c.R * 0.3) + (c.G * 0.59) + (c.B * 0.11));

        Console.Write(charArr[(grayScale/25)%10]+" ");
    }
    Console.WriteLine();
}










