class SearcherIds{
    private Dictionary<string,int> freqList;
    public void Search(IParseTree tree,Dictionary<string,int> freqList){
        this.freqList = freqList;
        new Visitor().Visit(tree);
    }

    class Visitor:CssBaseVisitor<object>{
        public override object VisitSimpleSelectorSequence([NotNull] CssParser.SimpleSelectorSequenceContext context) {
            var item = context.GetChild(0);
            if (item is TerminalNodeImpl) {
                var token = (TerminalNodeImpl)item;
                int index = token.Symbol.TokenIndex;
                string text = token[index].Text;
                if(freqList.ContainsKey()){
                    freqList[text]++;
                }else{
                    freqList.add(text,0);
                }
            }
            return base.VisitSimpleSelectorSequence(context);
        }
    }
}