

public class StoneCounter {

	static int stones;
	String takeStones;
	static int compStone;

	
	public StoneCounter() {
		stones = 17;		
	}
	
	public static String getStones() {
		return "There are " + stones + " left.";
	}
	
	public static void setStone(String removeStone) {
		stones -= Integer.parseInt(removeStone);
	}
	
	public static void setStone(int removeStone) {
		stones -= removeStone;
	}

	public static boolean checkInput(int stones2) {
		if (stones2 <= 3 && stones2 >= 1) {
			return true;
		}
		else {
			return false;
		}
		
	}
	
	public void compPlayer() {
		takeStones = SeventeenStones.stones;
		compStone = 4 - Integer.parseInt(takeStones);

		
//		if (stones == 3) {		
//			compStone = 2;
//		}
//		else if (stones == 2){
//			compStone = 1;
//		}
//		else {
//			if (MgSqMain.stones.equals("3")) {
//				compStone = 1;
//			}
//			else if (MgSqMain.stones.equals("2")) {
//				compStone = 2;
//			}
//			else if (MgSqMain.stones.equals("1")) {
//				compStone = 3;
//			}
//		}
		
		

	}
	
}
