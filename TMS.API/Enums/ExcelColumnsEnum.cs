using System.ComponentModel;

namespace TMS.API.Enums
{
    public enum ExcelColumnsEnum
    {
        A = 1,
        [Description("B")]
        B = 2,
        [Description("C")]
        C = 3,
        [Description("D")]
        D = 4,
        [Description("E")]
        E = 5,
        [Description("F")]
        F = 6,
        [Description("G")]
        G = 7,
        [Description("H")]
        H = 8,
        [Description("I")]
        I = 9,
        [Description("J")]
        J = 10,
        [Description("K")]
        K = 11,
        [Description("L")]
        L = 12,
        [Description("M")]
        M = 13,
        [Description("N")]
        N = 14,
        [Description("O")]
        O = 15,
        [Description("P")]
        P = 16,
        [Description("Q")]
        Q = 17,
        [Description("R")]
        R = 18,
        [Description("S")]
        S = 19,
        [Description("T")]
        T = 20,
        [Description("U")]
        U = 21,
        [Description("V")]
        V = 22,
        [Description("W")]
        W = 23,
        [Description("X")]
        X = 24,
        [Description("Y")]
        Y = 25,
        [Description("Z")]
        Z = 26,
    }

    public class GetColumnByNames
    {
        public ExcelColumnsEnum GetColumnByName(string column)
        {
            if (column.ToUpper() == "A")
            {
                return ExcelColumnsEnum.A;
            }
            else if (column.ToUpper() == "B")
            {
                return ExcelColumnsEnum.B;
            }
            else if (column.ToUpper() == "C")
            {
                return ExcelColumnsEnum.C;
            }
            else if (column.ToUpper() == "D")
            {
                return ExcelColumnsEnum.D;
            }
            else if (column.ToUpper() == "E")
            {
                return ExcelColumnsEnum.E;
            }
            else if (column.ToUpper() == "F")
            {
                return ExcelColumnsEnum.F;
            }
            else if (column.ToUpper() == "G")
            {
                return ExcelColumnsEnum.G;
            }
            else if (column.ToUpper() == "H")
            {
                return ExcelColumnsEnum.H;
            }
            else if (column.ToUpper() == "I")
            {
                return ExcelColumnsEnum.I;
            }
            else if (column.ToUpper() == "J")
            {
                return ExcelColumnsEnum.J;
            }
            else if (column.ToUpper() == "K")
            {
                return ExcelColumnsEnum.K;
            }
            else if (column.ToUpper() == "L")
            {
                return ExcelColumnsEnum.L;
            }
            else if (column.ToUpper() == "M")
            {
                return ExcelColumnsEnum.M;
            }
            else if (column.ToUpper() == "N")
            {
                return ExcelColumnsEnum.N;
            }
            else if (column.ToUpper() == "O")
            {
                return ExcelColumnsEnum.O;
            }
            else if (column.ToUpper() == "P")
            {
                return ExcelColumnsEnum.P;
            }
            else if (column.ToUpper() == "Q")
            {
                return ExcelColumnsEnum.Q;
            }
            else if (column.ToUpper() == "B")
            {
                return ExcelColumnsEnum.B;
            }
            else if (column.ToUpper() == "R")
            {
                return ExcelColumnsEnum.R;
            }
            else if (column.ToUpper() == "S")
            {
                return ExcelColumnsEnum.S;
            }
            else if (column.ToUpper() == "T")
            {
                return ExcelColumnsEnum.T;
            }
            else if (column.ToUpper() == "U")
            {
                return ExcelColumnsEnum.U;
            }
            else if (column.ToUpper() == "V")
            {
                return ExcelColumnsEnum.V;
            }
            else if (column.ToUpper() == "W")
            {
                return ExcelColumnsEnum.W;
            }
            else if (column.ToUpper() == "X")
            {
                return ExcelColumnsEnum.X;
            }
            else if (column.ToUpper() == "Y")
            {
                return ExcelColumnsEnum.Y;
            }
            else if (column.ToUpper() == "Z")
            {
                return ExcelColumnsEnum.Z;
            }
            return 0;
        }
    }
}
