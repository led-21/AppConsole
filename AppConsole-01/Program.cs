using System.Diagnostics;
using System.Drawing;

string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../Imagem/ponei.jpeg"));


int pixelsWidth = 200;

string mPath = "C:\\Users\\adria\\Source\\Repos\\led-21\\AppConsole-01\\AppConsole-01\\Imagem\\ponei.jpeg";

Desenhar(path);


void Desenhar(string path)
{

    Image img = Bitmap.FromFile(path);

    int pixelsHeigth = (int)(img.Height / img.Width * pixelsWidth);

    Bitmap imagem = new Bitmap(img, pixelsWidth, pixelsHeigth);

    char[] charArr = { '.', ',', '-', ';', ';', '\'', 'L', 'U', 'H', '0', ' ', '@' };


    for (int col = 0; col < imagem.Height; col++)
    {
        for (int line = 0; line < imagem.Width; line++)
        {
            Color c = imagem.GetPixel(line, col);
            byte grayScale = (byte)((c.R * 0.3) + (c.G * 0.59) + (c.B * 0.11));

            char caractere = charArr[(grayScale / 25) % 11];

            Colorir(caractere);
            Console.Write(caractere + " ");
            Descolorir();
        }


        Console.WriteLine();
    }
}


void Colorir(char c)
{
    if(c == 'H' || c == 'U')
        Console.ForegroundColor = ConsoleColor.DarkRed;
        
    if (c == 'L' || c == 'O' || c == '0')
        Console.ForegroundColor = ConsoleColor.Red;
    if (c == '-' || c == ',' )
        Console.ForegroundColor = ConsoleColor.Yellow;
    if (c == '.')
        Console.ForegroundColor = ConsoleColor.Black;
    

}

void Descolorir()
{
    Console.ForegroundColor = ConsoleColor.White;
}






