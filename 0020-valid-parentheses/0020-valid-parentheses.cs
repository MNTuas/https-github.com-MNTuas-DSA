public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach(char m in s){
            if(m == '(' || m == '[' || m == '{'){
                stack.Push(m);
            }else{
                if(stack.Count == 0) return false;
                char open = stack.Pop();
                if(m == ')' && open != '(' || m == '}' && open != '{' || m == ']' && open != '[')
                return false;

            }
        }
        return stack.Count == 0;
    }
}