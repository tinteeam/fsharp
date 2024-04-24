namespace fsharpc
{
    enum SyntaxKind
    {

    }

    class SyntaxToken
    {



        public SyntaxToken(SyntaxKind kind, int position, string text)
        {
            Kind = kind;
        }
        public SyntaxKind Kind { get; }

        public int Position { get; }

        public string Text { get; }


    }

    class Lexer
    {
        //readonly for _position
        private readonly string _text;

        private  int _position;

        public Lexer(string text)
        {
            _text = text;

        }

        private char Current
        {
            get
            {
                if (_position == _text.Length)
                {
                    return '\0';
                }
                return _text[_position];
            }
        }

        private void Next()
        {
            _position++;
        }

        public SyntaxToken NextToken()
        {
            if (char.IsDigit(Current) {
                var start = _position;
            }
            
                
            
        }
    }
}
