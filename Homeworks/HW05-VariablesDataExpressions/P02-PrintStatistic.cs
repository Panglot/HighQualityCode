public void PrintStatistics(double[] InputArray, int ArraySize)
{
    double Maximum = 0;
    for (int i = 0; i < ArraySize; i++)
    {
        if (InputArray[i] > Maximum)
        {
            Maximum = InputArray[i];
        }
    }

    PrintMax(Maximum);
    
    double Minimum = 0;
    for (int i = 0; i < ArraySize; i++)
    {
        if (InputArray[i] < Maximum)
        {
            Minimum = InputArray[i];
        }
    }

    PrintMin(Minimum);

    double  Sum = 0;
    for (int i = 0; i < ArraySize; i++)
    {
        Sum += InputArray[i];
    }

    PrintAvg(Sum / ArraySize);
}