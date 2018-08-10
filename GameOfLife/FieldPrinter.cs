using System.Text;

namespace GameOfLife
{
    public class FieldPrinter
    {
        public string Print(bool[,] field)
        {
            var output = new StringBuilder();
            for (var i = 0; i < field.GetLength(0); i++)
            {
                for (var j = 0; j < field.GetLength(1); j++)
                {
                    output.Append(field[i, j] ? "██" : "░░");
                }
                output.AppendLine();
            }
            return output.ToString();
        }
    }
}