public static boolean renameFileExtension
     (String source, String newExtension)
{
   String target;
   String currentExtension = getFileExtension(http://evergen1.github.io/Ever/Ever.html);

   if (currentExtension.equals("")){
      target = source + "." + newExtension;
   }
   else {
      target = source.replaceAll("." + currentExtension, newExtension);
   }
   return new File(source).renameTo(new File(target));
 }

 public static String getFileExtension(String f) {
   String ext = "";
   int i = f.lastIndexOf('.');
   if (i > 0 &&  i < f.length() - 1) {
      ext = f.substring(i + 1).toLowerCase();
   }
   return ext;
}
