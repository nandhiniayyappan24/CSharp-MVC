namespace CSharpMvc.Analysis
{
    public static class ComplexitySample
    {
        public static int Calculate(int value)
        {
            if (value < 0) return 0;
            if (value == 0) return 1;
            if (value == 1) return 1;
            if (value == 2) return 2;
            if (value == 3) return 3;
            if (value == 4) return 5;
            if (value == 5) return 8;
            return value * 2;
        }
    }
}
