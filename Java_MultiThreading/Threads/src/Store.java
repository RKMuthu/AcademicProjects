import java.util.ArrayList;


public class Store {
	private ArrayList<Item> items=new ArrayList<Item>();
	/**
	 * Constructor for store class containing the items of varying quantities
	 */
		Store()
	{
	Item item1=new Item("apple",50);
	Item item2=new Item("oranges",49);
	Item item3=new Item("pineapple",48);
	Item item4=new Item("persimmons",47);
	Item item5=new Item("kumquats",48);
	items.add(item1);
	items.add(item2);
	items.add(item3);
	items.add(item4);
	items.add(item5);
	System.out.println("Store Inventory");
	System.out.println("-----------------------------------------------------------------");
	System.out.println(items.get(0).getName()+": "+items.get(0).getQuantity()+", "+items.get(1).getName()+": "+items.get(1).getQuantity()+", "+items.get(2).getName()+": "+items.get(2).getQuantity()+", "+items.get(3).getName()+": "+items.get(3).getQuantity()+", "+items.get(4).getName()+": "+items.get(4).getQuantity());
	System.out.println("-----------------------------------------------------------------");
	}
		/*
		 * Getters and setters for the item objects in the arraylist
		 */
		public ArrayList<Item> getItems() {
			return items;
		}
		public void setItems(ArrayList<Item> items) {
			this.items = items;
		}
}
	