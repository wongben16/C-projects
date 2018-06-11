import java.math.BigInteger;
import java.util.Scanner;

import javax.swing.JOptionPane;

public class BGMain {

	static String question;
//	static long firstNum;
//	static long secondNum;
	static String firstNum;
	static String secondNum;
	static String operator;
	static BigInteger answer;
	
	
	
	public static void main(String[] args) {
		
	
		question = JOptionPane.showInputDialog("Enter an addition, subtraction, multiplication, or division problem:");
		System.out.println("Enter an addition, subtraction, multiplication, or division problem:");
		System.out.println(question);
		
		//test
//		question = "hello,      world hi";
		
		Scanner scan = new Scanner(question).useDelimiter("\\s+");
		
		//test
//		System.out.println(scan.next());
//		System.out.println(scan.next());
//		System.out.println(scan.next());
		
//		firstNum = Long.parseLong(scan.next());
//		operator = scan.next();
//		secondNum = Integer.parseInt(scan.next());
		
		firstNum = scan.next();
		operator = scan.next();
		secondNum = scan.next();
		BigInteger bigInt1 = new BigInteger(firstNum);
		BigInteger bigInt2 = new BigInteger(secondNum);
		

		answer = equationCreator(bigInt1, operator, bigInt2);
		System.out.println("= " + answer);
		JOptionPane.showMessageDialog(null, "= " + answer);
		
	}
	
	public static BigInteger equationCreator(BigInteger firstNum2, String op, BigInteger secondNum2) {
		
		if (op.equals("+")) {
			return firstNum2.add(secondNum2);
		}
		else if (op.equals("-")) {
			return firstNum2.subtract(secondNum2);
		}
		else if (op.equals("*")) {
			return firstNum2.multiply(secondNum2);
		}
		else if (op.equals("/")) {
			return firstNum2.divide(secondNum2);
		}
		else {
			return null;
		}
	}
	
	
}
