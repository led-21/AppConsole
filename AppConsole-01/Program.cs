using System.Diagnostics;
using System.Drawing;

string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../Imagem/ponei.jpeg"));

int pixelsWidth = 150;

string mPath = "C:\\Users\\adria\\Source\\Repos\\led-21\\AppConsole-01\\AppConsole-01\\Imagem\\ponei.jpeg";

Image img = Bitmap.FromFile(path);

int pixelsHeigth = (int)(img.Height / img.Width * pixelsWidth);

Bitmap imagem = new Bitmap(img, pixelsWidth, pixelsHeigth);

char[] charArr = { '.', ',', ',', ';', ';', '-', 'L', 'U', 'H', '#', '@' };


for (int col = 0; col < imagem.Height; col++)
{
    for (int line = 0; line < imagem.Width; line++)
    {
        Color c = imagem.GetPixel(line, col);
        byte grayScale = (byte)((c.R * 0.3) + (c.G * 0.59) + (c.B * 0.11));

        char caractere = charArr[(grayScale / 25) % 11];

        Console.Write(caractere + " ");

    }
    Console.WriteLine();
}




