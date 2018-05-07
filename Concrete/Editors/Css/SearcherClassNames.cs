public class SearcherClassNames{
    private Dictionary<string,int> freqList;
    public void Search(IParseTree tree,Dictionary<string,int> freqList){
        this.freqList = freqList;
        new Visitor().Visit(tree);
    }

    class Visitor: CssBaseVisitor<object>{
        public override object VisitClassName([NotNull] CssParser.ClassNameContext context) {
            var ident = context.ident();
            var nameIdent = ident.Ident();
            if (nameIdent != null) {
                int index = nameIdent.Symbol.TokenIndex;
                string text = token[index].Text;
                if(freqList.ContainsKey()){
                    freqList[text]++;
                }else{
                    freqList.add(text,0);
                }
            }
            return base.VisitClassName(context);
        }
    }
}