namespace Core.Messages
{
    public static class UIMessages
    {
        public static string GetRequiredMessage(string propName)
        {
            return $";{propName} boş ola bilməz";;
        }

        public static string GetMinLengthMessage(int length, string propName)
        {
            return $";{propName} {length} az ola bilməz";
        }

        public static string GetMaxLengthMessage(int length, string propName)
        {
            return $";{propName} {length} çox ola bilməz";
        }
    }
}
