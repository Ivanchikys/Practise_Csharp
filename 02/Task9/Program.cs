using Task9;

double A = Math.PI / 4;
double B = 4 / Math.PI;  
int M = 20;  

FunctionTabulation tabulator = new FunctionTabulation(A, B, M);
tabulator.Tabulate();