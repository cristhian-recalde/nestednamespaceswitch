namespace NestedNamespaceSwitch
{
    namespace Inner
    {
        namespace MyNamespace
        {
            class MyClassSwitch
            {
                public int getNumber(int num)
                {
                    int multiplier = 0;

                    switch (num)
                    {
                         case 1:
                             multiplier = 2;
                             break;
                         case 2:
                             multiplier = 5;
                             break;
                         case 3:
                             multiplier = 8;
                             break;
                         case 4:
                         case 5:
                         case 6:
                             multiplier = 4;
                             break;
                         case 7:
                             int nm = num % 2; 
                             switch (nm)
                             {
                                 case 0:
                                     multiplier++;
                                     break;
                                 case 2:
                                     multiplier += 3;
                                     break;
                                 default:
                                     multiplier -= 1;
                                     break;
                             }
                             break;
         
                    }

                    return num * multiplier;
                }
            }
        }
    }
}