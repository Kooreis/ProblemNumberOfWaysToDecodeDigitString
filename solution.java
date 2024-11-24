public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a digit string:");
        String digits = scanner.nextLine();
        System.out.println("Number of ways to decode: " + numDecodings(digits));
    }
}