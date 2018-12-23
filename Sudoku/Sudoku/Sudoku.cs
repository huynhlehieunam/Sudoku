using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Sudoku
    {
        public int[,] matrix;
        public int[,] covered;
        public int[,] player;
        int N;
        int SRN;
        int K;
        public Sudoku(int N, int K)
        {
            this.N = N;
            this.K = K;
            double SRNd = Math.Sqrt(N);
            SRN = Convert.ToInt32(SRNd);
            matrix = new int[N,N];
            covered = new int[N, N];
            player = new int[N, N];
        }
        

        public void fillValues()
        {
            fillDiagonal();
            fillRemaining(0, SRN);
            removeKDigits();
        }

        void fillDiagonal()
        {
            for (int i = 0; i < N; i = i + SRN)
                fillBox(i, i);
        }
        bool unUsedInBox(int rowStart, int colStart, int num)
        {
            for (int i = 0; i < SRN; i++)
                for (int j = 0; j < SRN; j++)
                    if (matrix[rowStart + i,colStart + j] == num)
                        return false;

            return true;
        }
        void fillBox(int row, int col)
        {
            int num;
            for (int i = 0; i < SRN; i++)
            {
                for (int j = 0; j < SRN; j++)
                {
                    do
                    {
                        num = randomGenerator(N);
                    }
                    while (!unUsedInBox(row, col, num));

                    matrix[row + i,col + j] = num;
                }
            }
        }
        int randomGenerator(int num)
        {
            Random r = new Random();
            return r.Next(num)+1;
        }

        bool CheckIfSafe(int i, int j, int num)
        {
            return (unUsedInRow(i, num) &&
                    unUsedInCol(j, num) &&
                    unUsedInBox(i - i % SRN, j - j % SRN, num));
        }
        bool unUsedInRow(int i, int num)
        {
            for (int j = 0; j < N; j++)
                if (matrix[i,j] == num)
                    return false;
            return true;
        }
        bool unUsedInCol(int j, int num)
        {
            for (int i = 0; i < N; i++)
                if (matrix[i,j] == num)
                    return false;
            return true;
        }
        bool fillRemaining(int i, int j)//0,3
        {
            if (j >= N && i < N - 1) //f
            {
                i = i + 1;
                j = 0;
            }
            if (i >= N && j >= N) //f
                return true;

            if (i < SRN) //t
            {
                if (j < SRN) //f
                    j = SRN;
            }
            else if (i < N - SRN)
            {
                if (j == (int)(i / SRN) * SRN)
                    j = j + SRN;
            }
            else
            {
                if (j == N - SRN)
                {
                    i = i + 1;
                    j = 0;
                    if (i >= N)
                        return true;
                }
            }

            for (int num = 1; num <= N; num++)
            {
                if (CheckIfSafe(i, j, num))
                {
                    matrix[i,j] = num;
                    if (fillRemaining(i, j + 1))
                        return true;

                    matrix[i,j] = 0;
                }
            }
            return false;
        }
        public void removeKDigits()
        {
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    covered[i, j] = matrix[i, j];
                }
            }
            int count = K;
            while (count != 0)
            {
                int cellId = randomGenerator(N*N-1);

                int i = (cellId / N);
                int j = cellId % 9;
                

                if (covered[i,j] != 0)
                {
                    count--;
                    covered[i,j] = 0;
                }
            }
        }
        public bool checkWin()
        {
            return (checkRow() && checkCol()/* && checkTotal()*/);
        }
        bool checkRow()
        {
            for(int i = 0; i < N; i++)
            {
                
                List<int> t = new List<int>();
                for (int j = 0; j < N; j++)
                {
                    
                    if (t.Contains(player[j, i]) == true) return false ;
                    t.Add(player[j, i]);
                }
                t.Clear();
            }
            return true;
        }
        bool checkCol()
        {
            for (int i = 0; i < N; i++)
            {
                List<int> t = new List<int>();
                for (int j = 0; j < N; j++)
                {
                    if (t.Contains(player[i, j]) == true) return false;
                    t.Add(player[i, j]);
                }
                t.Clear();
            }
            return true;
        }
        bool checkSquare(int rS,int cS)
        {
            List<int> t = new List<int>();
            for (int i=rS; i < rS + SRN; i++)
            {
                for (int j = cS; j < cS + SRN; j++)
                {
                    if (t.Contains(player[i, j]) == true) return false;
                }
            }
            return true;
        }
        bool checkTotal()
        {
            for(int i=0;i<N;i+=SRN)
                for (int j = 0; j < N; j+=SRN)
                {
                    if (checkSquare(i, j) == false) return false;
                };
            return true;
        }
    }
}
