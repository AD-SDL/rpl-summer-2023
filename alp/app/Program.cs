using System;
using System.IO;
using System.Linq;

class TipRefill {
    static void Main() {
        tipRefill(3);
    }

    private static void tipRefill(int boxIndex){
        string filePath = "../TipCounts.csv";
        int targetRow = boxIndex; 
        int targetColumn = 3;
        Console.WriteLine("Hello, World!");
        string refillLine = "1";
        for(int i = 0; i < 95; i++){
            refillLine = refillLine + "|1"; 
        }
        // Read the contents of the CSV file
        string[] lines = File.ReadAllLines(filePath);

        // Check if the target row exists
        if (targetRow > 0 && targetRow <= lines.Length) {
            // Split the line into columns
            string[] columns = lines[targetRow - 1].Split(',');
            // Check if the target column exists
            if (targetColumn > 0 && targetColumn <= columns.Length) {
                // Update the value at the target column
                columns[targetColumn - 1] = refillLine;
                // Join the columns back into a line
                string updatedLine = string.Join(",", columns);
                // Update the line in the CSV file
                lines[targetRow - 1] = updatedLine;
                // Write the updated contents back to the CSV file
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Value updated successfully.");
            }
            else {
                Console.WriteLine("Invalid target column.");
            }
        }
        else {
            Console.WriteLine("Invalid target row.");
        }
    }
}