    public static boolean flag = initializeClassVariable();
    static int B;
    static int H;
    private static boolean initializeClassVariable() {

        Scanner sc = new Scanner(System.in);
         B = sc.nextInt();
         H = sc.nextInt();
        if(B<=0 || H<=0) {
            System.out.println("java.lang.Exception: Breadth and height must be positive");
            return false;
        } else {
            return true;
        }
    }
