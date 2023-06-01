// Author : Ahmed Samir
// Link Problem : https://leetcode.com/problems/goal-parser-interpretation/
public class Solution {
    public string Interpret(string command) {
         string res="";

            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == '(' && (command[i +1] == ')'))
                {
                    res+="o";
                }
                else if(command[i] == '(' && command[i+1] == 'a')
                {
                    res+="al";
                    i += 3;
                }
                else if(command[i]=='G')
                {
                    res += 'G';
                }

            }

            return res;
    }
}
