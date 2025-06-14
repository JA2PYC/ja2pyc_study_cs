// See https://aka.ms/new-console-template for more information
Console.WriteLine("Multi Dimensional Array");


// Multi Dimensional Array with short type example
short[,,] shorts = new short[2, 3, 4]; // Declare a 3D array with dimensions 2x3x4
shorts[0, 0, 0] = 1; // Assign a value to the first element of the 3D array
shorts[0, 0, 1] = 2; // Assign a value to the second element of the first row in the first layer

Console.WriteLine($"Shorts Length: {shorts.Length}"); // Print the total number of elements in the 3D array
Console.WriteLine($"Shorts[0,0,0]: {shorts[0, 0, 0]}, Shorts[0,0,1]: {shorts[0, 0, 1]}"); // Print the first two elements of the 3D array

// Multi Dimensional Array example
int[,] ints = new int[3, 3]; // Declare a 2D array (matrix) with 3 rows and 3 columns
ints[0, 0] = 1; // Assign a value to the first element of the matrix
ints[0, 1] = 2; // Assign a value to the second element of the first row

Console.WriteLine($"Ints Length: {ints.Length}"); // Print the total number of elements in the matrix
Console.WriteLine($"Ints[0,0]: {ints[0, 0]}, Ints[0,1]: {ints[0, 1]}"); // Print the first two elements of the matrix

// Declare and initialize a 2D array with values
int[,] matrix = new int[2, 3] {
    { 1, 2, 3 }, { 4, 5, 6 }
}; // Declare and initialize a 2D array with values

Console.WriteLine($"Matrix Length: {matrix.Length}"); // Print the total number of elements in the initialized matrix
Console.WriteLine($"Matrix[0,0]: {matrix[0, 0]}, Matrix[1,2]: {matrix[1, 2]}"); // Print specific elements of the initialized matrix

// Declare a 3D array (3D matrix) with dimensions 2x3x4
int[,,] matrix3D = new int[2, 3, 4]
    {
        { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } },
      { { 13, 14, 15, 16 }, { 17, 18, 19, 20 }, { 21, 22, 23, 24 } }
    }; // Initialize the 3D array with values

Console.WriteLine($"Matrix3D Length: {matrix3D.Length}"); // Print the total number of elements in the 3D matrix
Console.WriteLine($"Matrix3D[0,0,0]: {matrix3D[0, 0, 0]}, Matrix3D[1,2,3]: {matrix3D[1, 2, 3]}"); // Print specific elements of the 3D matrix

// Jagged Array example
int[][] jaggedArray = new int[3][]; // Declare a jagged array with 3 rows
jaggedArray[0] = new int[2]; // Initialize the first row with 2 columns
jaggedArray[0][0] = 1; // Assign a value to the first element of the first row
jaggedArray[0][1] = 2; // Assign a value to the second element of the first row
jaggedArray[1] = new int[3]; // Initialize the second row with 3 columns
jaggedArray[1][0] = 3; // Assign a value to the first element of the second row
jaggedArray[1][1] = 4; // Assign a value to the second element of the second row

Console.WriteLine($"JaggedArray Length: {jaggedArray.Length}"); // Print the number of rows in the jagged array
Console.WriteLine($"JaggedArray[0][0]: {jaggedArray[0][0]}, JaggedArray[0][1]: {jaggedArray[0][1]}"); // Print the first two elements of the first row
Console.WriteLine($"JaggedArray[1][0]: {jaggedArray[1][0]}, JaggedArray[1][1]: {jaggedArray[1][1]}"); // Print the first two elements of the second row


Console.WriteLine("Press any key to exit..."); // Prompt the user to press a key before exiting
Console.ReadKey(); // Wait for the user to press a key