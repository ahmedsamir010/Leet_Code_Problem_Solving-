class Solution {
public:
        int mostWordsFound(vector<string>& sentences) {
            	int Max = 0;
	for (size_t i = 0; i < sentences.size(); i++)
	{
		int c = 1;
		string test = sentences[i];
		for (size_t j = 0; j < test.size(); j++)
		{
			if (test[j] == ' ' && test[j + 1] != ' ')
				c++;

		}
		Max = max(Max, c);
	}
	return Max;
           
        }
};
