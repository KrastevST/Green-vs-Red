using System.Security.Cryptography.X509Certificates;

namespace GreenVsRed
{
    public class Generation
    {
        private int x;
        private int y;
        private int[,] grid;
        private int x1;
        private int y1;

        public Generation(int x, int y, int[,] genZero, int x1, int y1)
        {
            this.x = x;
            this.y = y;
            this.grid = genZero;
            this.x1 = x1;
            this.y1 = y1;
        }
    }
}
