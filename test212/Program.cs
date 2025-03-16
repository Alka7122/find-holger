
  
int rows = 40;
int cols = 40;

Random rand = new Random();

char[,] grid = new char[rows, cols];

string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";

for (int row = 0; row < rows; row++)
 {
  for (int col = 0; col < cols; col++)
   {
               
   grid[row, col] = chars[rand.Next(chars.Length)];
   }
 }

int randRow = rand.Next(rows);
int randCol = rand.Next(cols);
grid[randRow, randCol] = '@'; 

Console.WriteLine("Generated Grid:");
for (int row = 0; row < rows; row++)
 {
  for (int col = 0; col < cols; col++)
   {
    Console.Write(grid[row, col] + " ");
   }
    Console.WriteLine();
 }

   