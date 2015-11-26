
class Animal {
    void jump() { System.out.println("Animal"); }
}
class Cat extends Animal {
    void jump(int a) { System.out.println("Cat"); }
}
class Rabbit extends Animal {
    void jump() { System.out.println("Rabbit"); }
}
class Circus {

    static StringBuilder stringBuilder = new StringBuilder("test");

    private static StringBuilder test() {
        int[] a = {1, 3, 5};

        try {
            a[4] = 4;
        } catch (ArrayIndexOutOfBoundsException e) {
            System.out.println("catch" + " " + stringBuilder);
            return stringBuilder;
        } finally {
            stringBuilder.append("test");
            System.out.println("finally" + " " + (stringBuilder));
            //return 2;
        }

        return null;
    }

    private static String getTest() throws ArrayIndexOutOfBoundsException{
        String[] students = {"Shreya", "Joseph"};
        try {
            return students[5];
        } catch (ArrayIndexOutOfBoundsException e) {
            System.out.println("Exception");
            throw e;
        }
    }

    static int a = 10;
    int b = 5;
    {a=4; b = 5;}
    public static int[ ] getArray() { return null; }
    public static void main(String[] args){
        int a = 1;
        int[] ia = new int[10];
        int b = ia[a];
        int c = b + a;
        System.out.println(b = c);    }
}
class a {
        public static void methodX() throws Exception {
            throw new AssertionError();
        }

    public static void stringTest(String s){
        s.replace('h', 's');
    }
    public static void stringBuilderTest(StringBuilder s){
        s.append("o");
    }
    public static void main(String[] args){
        String s = "hell";
        StringBuilder sb = new StringBuilder("well");
        stringTest(s);
        stringBuilderTest(sb);
        System.out.println(s + sb);
    }


    }

 class TestClass{
     void test(int x){
         switch(x){
             case 1:
             case 2:
             case 0:
             default :
             case 4:
         }
     }
    public static void main(String[] args) {

    }

 }
class Super { static String ID = "QBANK"; }
class Sub extends Super{
    static { System.out.print("In Sub"); }
}
 class Test{
    public static void main(String[] args){
        System.out.println(new Sub().ID);
    }
}