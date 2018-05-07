static public TypeFile GetTypeFile(string pathFile) {
            int indexPoint = pathFile.LastIndexOf('.');
            if (indexPoint == -1) {
                return TypeFile.None;
            }

            string type = pathFile.Substring(indexPoint + 1);
            switch (type.ToUpper()) {
                case "CSS":
                    return TypeFile.Css;
                case "HTML":
                    return TypeFile.Html;
                case "JS":
                    return TypeFile.Js;
                default:
                    return TypeFile.None;
            }
}