using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokeSolver2
{
    class Program
    {
        static void Main(string[] args)
        {
            SudokuVeld veld = new SudokuVeld();
            List<KeyValuePair<int, int>> start = new List<KeyValuePair<int, int>>();
            start.Add(new KeyValuePair<int, int>(2, 3));
            start.Add(new KeyValuePair<int, int>(4, 4));
            start.Add(new KeyValuePair<int, int>(13, 5));
            start.Add(new KeyValuePair<int, int>(16, 8));
            start.Add(new KeyValuePair<int, int>(20, 8));
            start.Add(new KeyValuePair<int, int>(24, 2));
            start.Add(new KeyValuePair<int, int>(25, 3));
            start.Add(new KeyValuePair<int, int>(26, 4));
            start.Add(new KeyValuePair<int, int>(30, 7));
            start.Add(new KeyValuePair<int, int>(33, 1));
            start.Add(new KeyValuePair<int, int>(36, 9));
            start.Add(new KeyValuePair<int, int>(38, 6));
            start.Add(new KeyValuePair<int, int>(41, 5));
            start.Add(new KeyValuePair<int, int>(45, 1));
            start.Add(new KeyValuePair<int, int>(50, 3));
            start.Add(new KeyValuePair<int, int>(52, 4));
            start.Add(new KeyValuePair<int, int>(56, 2));
            start.Add(new KeyValuePair<int, int>(59, 4));
            start.Add(new KeyValuePair<int, int>(60, 7));
            start.Add(new KeyValuePair<int, int>(61, 8));
            start.Add(new KeyValuePair<int, int>(75, 6));
            start.Add(new KeyValuePair<int, int>(79, 1));
            start.Add(new KeyValuePair<int, int>(81, 9));
            foreach (KeyValuePair<int, int> k in start)
            {
                SudokuPunt enter = new SudokuPunt(k.Key, k.Value);
                enter.setVast();
                veld.putPunt(enter);
            }
            veld.solve();
            Console.Read();
        }

        public void oplos()
        {

        }

        public static int[] getTegenKlok(int index)
        {
            int[] indexTegenKlok1 = { 1, 10, 19, 76, 67, 58, 52, 53, 34 };
            int[] indexTegenKlok2 = { 2, 11, 20, 77, 68, 59, 53, 44, 35 };
            int[] indexTegenKlok3 = { 3, 12, 21, 78, 69, 60, 54, 45, 36 };
            int[] indexTegenKlok4 = { 46, 37, 28, 22, 13, 4, 79, 70, 61 };
            int[] indexTegenKlok5 = { 47, 38, 29, 23, 14, 5, 80, 71, 62 };
            int[] indexTegenKlok6 = { 48, 39, 30, 24, 15, 6, 81, 72, 63 };
            int[] indexTegenKlok7 = { 73, 64, 55, 49, 40, 31, 25, 16, 7 };
            int[] indexTegenKlok8 = { 74, 65, 56, 50, 41, 32, 26, 17, 8 };
            int[] indexTegenKlok9 = { 75, 66, 57, 51, 42, 33, 27, 18, 9 };

            int[] puntInLijst = { 0, 0 };

            if (indexTegenKlok1.Contains(index))
            {

                for (int i = 0; i < 9; i++)
                {
                    if (indexTegenKlok1[i] == index)
                    {
                        puntInLijst[0] = 0;
                        puntInLijst[1] = i;
                    }
                }
            }

            else if (indexTegenKlok2.Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (indexTegenKlok2[i] == index)
                    {
                        puntInLijst[0] = 1;
                        puntInLijst[1] = i;
                    }
                }
            }

            else if (indexTegenKlok3.Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (indexTegenKlok3[i] == index)
                    {
                        puntInLijst[0] = 2;
                        puntInLijst[1] = i;
                    }
                }
            }

            else if (indexTegenKlok4.Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (indexTegenKlok4[i] == index)
                    {
                        puntInLijst[0] = 3;
                        puntInLijst[1] = i;
                    }
                }
            }

            else if (indexTegenKlok5.Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (indexTegenKlok5[i] == index)
                    {
                        puntInLijst[0] = 4;
                        puntInLijst[1] = i;
                    }
                }
            }

            else if (indexTegenKlok6.Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (indexTegenKlok6[i] == index)
                    {
                        puntInLijst[0] = 5;
                        puntInLijst[1] = i;
                    }
                }
            }

            else if (indexTegenKlok7.Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (indexTegenKlok7[i] == index)
                    {
                        puntInLijst[0] = 6;
                        puntInLijst[1] = i;
                    }
                }
            }

            else if (indexTegenKlok8.Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (indexTegenKlok8[i] == index)
                    {
                        puntInLijst[0] = 7;
                        puntInLijst[1] = i;
                    }
                }
            }

            else if (indexTegenKlok9.Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (indexTegenKlok9[i] == index)
                    {
                        puntInLijst[0] = 8;
                        puntInLijst[1] = i;
                    }
                }
            }
            return puntInLijst;
        }

        public static int[] getVak(int index, List<int[]> vakIndices)
        {
            int[] puntInLijst = { 0, 0 };

            if (vakIndices[0].Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (vakIndices[0][i] == index)
                    {
                        puntInLijst[0] = 0;
                        puntInLijst[1] = i;
                    }
                }
            }

            else if (vakIndices[1].Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (vakIndices[1][i] == index)
                    {
                        puntInLijst[0] = 1;
                        puntInLijst[1] = i;
                    }
                }
            }
            else if (vakIndices[2].Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (vakIndices[2][i] == index)
                    {
                        puntInLijst[0] = 2;
                        puntInLijst[1] = i;
                    }
                }
            }
            else if (vakIndices[3].Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (vakIndices[3][i] == index)
                    {
                        puntInLijst[0] = 3;
                        puntInLijst[1] = i;
                    }
                }
            }
            else if (vakIndices[4].Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (vakIndices[4][i] == index)
                    {
                        puntInLijst[0] = 4;
                        puntInLijst[1] = i;
                    }
                }
            }
            else if (vakIndices[5].Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (vakIndices[5][i] == index)
                    {
                        puntInLijst[0] = 5;
                        puntInLijst[1] = i;
                    }
                }
            }

            else if (vakIndices[6].Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (vakIndices[6][i] == index)
                    {
                        puntInLijst[0] = 6;
                        puntInLijst[1] = i;
                    }
                }
            }

            else if (vakIndices[7].Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (vakIndices[7][i] == index)
                    {
                        puntInLijst[0] = 7;
                        puntInLijst[1] = i;
                    }
                }
            }
            else if (vakIndices[8].Contains(index))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (vakIndices[8][i] == index)
                    {
                        puntInLijst[0] = 8;
                        puntInLijst[1] = i;
                    }
                }
            }
            return puntInLijst;
        }

        public static int[] getKlok(int index)
        {
            int[] puntInLijst = { 0, 0 };
            puntInLijst[0] = (index - 1) / 9;
            int mod = index % 9;
            if (mod == 0)
            {
                puntInLijst[1] = 8;
            }
            else
            {
                puntInLijst[1] = mod - 1;
            }
            return puntInLijst;
        }


        public class SudokuPunt
        {
            int waarde; int index; bool vast = false;
            int tegenKlok; int vak;

            public SudokuPunt(int indexIn, int waardeIn)
            {
                waarde = waardeIn;
                index = indexIn;
            }

            public void setVast()
            {
                vast = true;
            }

            public bool isVast()
            {
                return vast;
            }
            public void setTegenKlok(int input)
            {
                tegenKlok = input;
            }

            public void setVak(int input)
            {
                vak = input;
            }
            public void setWaarde(int waardeIn)
            {
                waarde = waardeIn;
            }

            public int getWaarde()
            {
                return waarde;
            }
            public void setIndex(int indexIn)
            {
                index = indexIn;
            }
            public int getIndex()
            {
                return index;
            }

        }

        public class SudokuVeld
        {

            private List<List<SudokuPunt>> vakken = new List<List<SudokuPunt>>();
            private List<List<SudokuPunt>> klok = new List<List<SudokuPunt>>();
            private List<List<SudokuPunt>> tegenKlok = new List<List<SudokuPunt>>();
            private List<SudokuPunt> allePunten = new List<SudokuPunt>();

            List<int[]> vakIndices = new List<int[]>();
            int[] indexVak1 = { 1, 2, 3, 10, 11, 12, 19, 20, 21 };
            int[] indexVak2 = { 4, 5, 6, 13, 14, 15, 22, 23, 24 };
            int[] indexVak3 = { 7, 8, 9, 16, 17, 18, 25, 26, 27 };
            int[] indexVak4 = { 28, 29, 30, 37, 38, 39, 46, 47, 48 };
            int[] indexVak5 = { 31, 32, 33, 40, 41, 42, 49, 50, 51 };
            int[] indexVak6 = { 34, 35, 36, 43, 44, 45, 52, 53, 54 };
            int[] indexVak7 = { 55, 56, 57, 64, 65, 66, 73, 74, 75 };
            int[] indexVak8 = { 58, 59, 60, 67, 68, 69, 76, 77, 78 };
            int[] indexVak9 = { 61, 62, 63, 70, 71, 72, 79, 80, 81 };

            public SudokuVeld()
            {
                vakIndices.Add(indexVak1); vakIndices.Add(indexVak2); vakIndices.Add(indexVak3); vakIndices.Add(indexVak4); vakIndices.Add(indexVak5); vakIndices.Add(indexVak6); vakIndices.Add(indexVak7); vakIndices.Add(indexVak8); vakIndices.Add(indexVak9);
                for (int i = 0; i < 9; i++)
                {
                    List<SudokuPunt> dummyLijst = new List<SudokuPunt>();
                    for (int j = 0; j < 9; j++)
                    {
                        SudokuPunt dummyPunt = new SudokuPunt(i, 0);
                        dummyLijst.Add(dummyPunt);
                    }
                    vakken.Add(dummyLijst);
                }

                for (int i = 0; i < 9; i++)
                {
                    List<SudokuPunt> dummyLijst = new List<SudokuPunt>();
                    for (int j = 0; j < 9; j++)
                    {
                        SudokuPunt dummyPunt = new SudokuPunt(i, 0);
                        dummyLijst.Add(dummyPunt);
                    }
                    klok.Add(dummyLijst);
                }

                for (int i = 0; i < 9; i++)
                {
                    List<SudokuPunt> dummyLijst = new List<SudokuPunt>();
                    for (int j = 0; j < 9; j++)
                    {
                        SudokuPunt dummyPunt = new SudokuPunt(i, 0);
                        dummyLijst.Add(dummyPunt);
                    }
                    tegenKlok.Add(dummyLijst);
                }

                for (int i = 1; i <= 81; i++)
                {
                    SudokuPunt punt = new SudokuPunt(i, 0);
                    putPunt(punt);
                }

            }

            public int getValue(int index)
            {
                int vakNummer = getVak(index, vakIndices)[0];
                int vakPlaats = getVak(index, vakIndices)[1];
                return vakken[vakNummer][vakPlaats].getWaarde();
            }

            public void setValue(int index, int waarde)
            {
                int vakNummer = getVak(index, vakIndices)[0];
                int vakPlaats = getVak(index, vakIndices)[1];
                vakken[vakNummer][vakPlaats].setWaarde(waarde);
            }

            public void putPunt(SudokuPunt punt)
            {
                insertInVak(punt);
                insertInTegenKlok(punt);
                insertInKlok(punt);
                allePunten.Add(punt);
            }

            public void insertInVak(SudokuPunt punt)
            {
                int i = punt.getIndex();
                int[] puntVak = getVak(i, vakIndices);
                int welkVak = puntVak[0];
                int puntInVak = puntVak[1];
                vakken[welkVak][puntInVak] = punt;
            }

            public void insertInTegenKlok(SudokuPunt punt)
            {
                int i = punt.getIndex();
                int[] puntTegenKlok = getTegenKlok(i);
                int welkTegenKlok = puntTegenKlok[0];
                int puntInTegenKlok = puntTegenKlok[1];
                tegenKlok[welkTegenKlok][puntInTegenKlok] = punt;
            }

            public void insertInKlok(SudokuPunt punt)
            {
                int i = punt.getIndex();
                int[] puntKlok = getKlok(i);
                int welkKlok = puntKlok[0];
                int puntInKlok = puntKlok[1];
                klok[welkKlok][puntInKlok] = punt;
            }

            public bool possible(int index, int waarde)
            {
                if (!checkVak(index, waarde, vakIndices))
                {
                    return false;
                }

                if (!checkKlok(index, waarde))
                {
                    return false;
                }
                if (!checkTegenKlok(index, waarde))
                {
                    return false;
                }
                return true;
            }

            private bool checkVak(int index, int waarde, List<int[]> vakIndices)
            {
                int welkVak = getVak(index, vakIndices)[0];
                foreach (SudokuPunt punt in vakken[welkVak])
                {
                    if (waarde == punt.getWaarde())
                    {
                        return false;
                    }
                }
                return true;
            }

            private bool checkKlok(int index, int waarde)
            {
                int welkKlok = getKlok(index)[0];
                foreach (SudokuPunt punt in klok[welkKlok])
                {
                    if (waarde == punt.getWaarde())
                    {
                        return false;
                    }
                }
                return true;
            }

            private bool checkTegenKlok(int index, int waarde)
            {
                int welkTegenKlok = getTegenKlok(index)[0];
                foreach (SudokuPunt punt in tegenKlok[welkTegenKlok])
                {
                    if (waarde == punt.getWaarde())
                    {
                        return false;
                    }
                }
                return true;
            }

            public void print()
            {
                Console.Write("\nStart");
                foreach (List<SudokuPunt> punten in klok)
                {
                    Console.WriteLine("\nNieuwe klokrij");
                    foreach (SudokuPunt punt in punten)
                    {
                        Console.Write($" {punt.getWaarde()}");
                    }
                }
            }

            public void solve()
            {
                for (int index = 1; index <= 81; index++)
                {
                    if (getValue(index) == 0)
                    {
                        for (int waarde = 1; waarde <= 9; waarde++)
                        {
                            if (possible(index, waarde))
                            {
                                setValue(index, waarde);
                                solve();
                            }
                        }
                        setValue(index, 0);
                    }
                }
                print();
            }

        }
    }
}