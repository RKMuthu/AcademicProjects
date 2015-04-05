import java.util.ArrayList;
import java.util.Random;

public class CustomerRunnable implements Runnable {
	private Store store;
	private String itemname1;
	private String itemname2;
	private String itemname3;
	private String itemname4;
	private String itemname5;
	Random rand=new Random();
	ArrayList<String> items=new ArrayList<String>();
	/*
	 * constructor which initializes the customer item names
	 */
	public CustomerRunnable(Store obj) {
		store=obj;
		itemname1="apple";
		itemname2="oranges";
		itemname3="pineapple";
		itemname4="persimmons";
		itemname5="kumquats";
		items.add(itemname1);
		items.add(itemname2);
		items.add(itemname3);
		items.add(itemname4);
		items.add(itemname5);
	}

	@Override
	public void run() {
	String name = Thread.currentThread().getName();
	int quantity1;
	int quantity2;
	int quantity3;
	int quantity4;
	int quantity5;
	while(true)
	{
		/*
		 * Generate a random quantity for each time a customer 
		 */
	ArrayList<Item> itemlist=store.getItems();
	ArrayList<Integer> quantities=new ArrayList<Integer>();
	quantity1=rand.nextInt(21);
	quantity2=rand.nextInt(21);
	quantity3=rand.nextInt(21);
	quantity4=rand.nextInt(21);
	quantity5=rand.nextInt(21);
	quantities.add(quantity1);
	quantities.add(quantity2);
	quantities.add(quantity3);
	quantities.add(quantity4);
	quantities.add(quantity5);
	/*
	 * sleep the customer for 50ms before making the request
	 */
	try {
		Thread.sleep(50);
	} catch (InterruptedException e1) {
		System.out.println("Interrupted during sleep for thread "+name);
	}
	synchronized (store) {
	while(true)
	{
		System.out.println(name +" requests, "+quantity1+" "+itemlist.get(0).getName()+", "+quantity2+" "+itemlist.get(1).getName()+", "+quantity3+" "+itemlist.get(2).getName()+", "+quantity4+" "+itemlist.get(3).getName()+", "+quantity5+" "+itemlist.get(4).getName());
		boolean itemvalue=true;
		boolean quantityvalue=true;
		/*
		 * Check for item names in the store in which the customer item name is same or not
		 */
	for(int i=0;i<items.size();i++)
	{
		if(!((itemlist.get(i).getName()).equals(items.get(i))))
		{
			System.out.println("Invalid Itemname given");
			itemvalue=false;
			break;
		}
	}
	for(int i=0;i<quantities.size();i++)
	{
		itemlist.get(i).setTempQuantity((itemlist.get(i).getTempQuantity())-(quantities.get(i)));
	}
	/*
	 * check for if the store has enough item for the customer requests.
	 */
	for(int i=0;i<quantities.size();i++)
	{
		int a=((itemlist.get(i).getQuantity())-(quantities.get(i)));
		if(a<0)
		{
			quantityvalue=false;
			break;
		}
	}
	/*
	 * if the store has enough items,set the new quantity value for the item according to the customer requests.
	 */
	if(itemvalue&&quantityvalue)
	{
		for(int i=0;i<itemlist.size();i++)
		{
			itemlist.get(i).setQuantity((itemlist.get(i).getQuantity())-(quantities.get(i)));
		}
		break;
	}
	else
	{
		/*
		 * If the customer order more items,the wait for them until the restocking happens by manager.
		 */
		try {
			System.out.println(name+" Waiting.........");
			System.out.println();
			store.wait();
		} catch (InterruptedException e) {
			System.out.println("Interrupted during wait for thread "+name);
		}
	}
	}
		System.out.println("Request Fulfilled");	
		System.out.println();
		System.out.println("----------------------------------------------------------------");
		System.out.println("Store Inventory");
		System.out.println("-----------------------------------------------------------------");
		System.out.println(itemlist.get(0).getName()+": "+itemlist.get(0).getQuantity()+", "+itemlist.get(1).getName()+": "+itemlist.get(1).getQuantity()+", "+itemlist.get(2).getName()+": "+itemlist.get(2).getQuantity()+", "+itemlist.get(3).getName()+": "+itemlist.get(3).getQuantity()+", "+itemlist.get(4).getName()+": "+itemlist.get(4).getQuantity());
		System.out.println("-----------------------------------------------------------------");
		System.out.println();
		}
	}
	}

}