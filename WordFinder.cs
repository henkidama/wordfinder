namespace WordExercise;
public class WordFinder : IWordFinder
{
    private const int top = 10;
    private IEnumerable<string> grid;
    private Dictionary<string, int> words;
    private bool[,] visited;
    private int matrixLength;

/*
* the time of this algorithm is O(V + E) the V is the number of vertices and E is the number of Edges in this case
* the edges are the letter that we are looking for
*
*             A           
*             .
*        D <--O--> G
*             .
*             Y
*
* we have 4 vertices here and 4 edges as well, this is why the time is O(V + E) and is the same for our case leftright and topdown
* the space complexity is O(V) because we are visiting every letter of the matrix
*/

    public WordFinder(IEnumerable<string> Matrix)
    {
        if(Matrix == null) 
        throw new NullReferenceException("you can't pass the Matrix as null, please initialize it before to send the matrix");

        //we are going to initialize the matriz into an array for finding the words.\
        grid = Matrix;
        matrixLength = Matrix.Count();
        visited = new bool [matrixLength, matrixLength];
        words = new Dictionary<string, int>();
    }

    public IEnumerable<string> Find(IEnumerable<string> wordstream)
    {
        if(wordstream == null) return new List<string>();

        foreach (var item in wordstream)
        {
            if(item == null || item.Length > matrixLength) continue;

            for (int row = 0; row < visited.Length; row++)
            {
                for (int col = 0; col < visited.Length; col++)
                {
                    //if we are looking only one letter we must to search from left to right only
                    if(item.Length == 1)
                    {
                        Search(row, col, grid, item, 0, visited, eSearch.LeftRight);
                    }
                    else
                    {
                        Search(row, col, grid, item, 0, visited, eSearch.LeftRight);
                        Search(row, col, grid, item, 0, visited, eSearch.TopBottom);
                    }
                }
            }
        }

        if(words.Count > 0)
        {
            //we are going to sort by value that is the times is getting the word repeated and as the last step we are going to take the top 10
            var topWords = words
            .OrderByDescending(o => o.Value)
            .ToList();

            int counter = 0;
            int lastValue = 0;
            var listResult = new List<string>();
            int totalWords = topWords.Count();

            //we can have more than top 10 in this case, because if we have for example 18,11,9,8,7,6,5,4,3,3,2,2,1
            //as we can see we can return 18,11,9,8,7,6,5,4,3,3,2,2 because 3 and 2 are repeating n times but we are going to plus 1 to the counter
            //if this rule it's not valid we can only sort the top 10 in ascending order
            for (int i = 0; i < totalWords; i++)
            {
                if(counter > top)
                {
                    i = totalWords;
                    continue;
                }
                else
                {
                    if(lastValue != topWords[i].Value) counter++;

                    if(counter <= top)
                     listResult.Add(topWords[i].Key);
                }

                lastValue = topWords[i].Value;
            }

            return listResult;
        }
        //if we didn't find anything we're gonna return an empty list
        else return new List<string>();
    }

    private void Search(int row, int col, IEnumerable<string> matrix, string word, int index, bool[,] isVisited, eSearch eSearch)
    {
        if(index == word.Length)
        {
            //we're using a dictionary because we need to search the word in constant time O(1)
            if(words.ContainsKey(word))
            {
                words[word]++;
            }
            else
            {
                //if it's the first time you need to add 1
                words.Add(word, 1);
            }
            //we need to reset the value to 0 because we want to search the word n times
            index = 0;
        }

        if(row < 0 || row >= matrixLength || col < 0  || col >= matrixLength) return;
        if(word[index] != matrix.ElementAt(row)[col]) return;
        if(isVisited[row, col]) return;

        isVisited[row, col] = true;
        
        //we need to setting up the type of search
        switch(eSearch)
        {
            case eSearch.LeftRight:
            Search(row, col + 1, matrix, word, index + 1, isVisited, eSearch);
            break;

            case eSearch.TopBottom:
            Search(row + 1, col, matrix, word, index + 1, isVisited, eSearch);
            break;
        }
            
        isVisited[row, col] = false;
    }

    private enum eSearch
    {
        LeftRight,
        TopBottom
    }
}