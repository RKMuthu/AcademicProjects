import java.util.ArrayList;


public class ManagerRunnable implements Runnable {
	private Store store;
	/*
	 * Constructor which has the store objects for synchronization
	 */
	ManagerRunnable(Store obj)
	{
		store=obj;
	}
	@Override
	public void run() {
		String name = Thread.currentThread().getName();
		while(true)
		{
		ArrayList<Item> items=store.getItems();
		boolean check=false;
		/*
		 * Sleeps for 50ms
		 */
		try {
			Thread.sleep(50);
		} catch (InterruptedException e) {
			System.out.println("Interrupted during sleep for thread "+name);
		}
		synchronized (store) {
			/*
			 * Checks for any quantity is less than zero.
			 */
			for(int i=0;i<items.size();i++)
			{
				if((items.get(i).getTempQuantity())<0)
				{
					check=true;
					break;
				}
			}
			/*
			 * If any quantity is less than zero,restock the inventory
			 */
			if(check)
			{
				for(int i=0;i<items.size();i++)
				{
					items.get(i).setQuantity(50);
					items.get(i).setTempQuantity(50);
				}
				System.out.println("**Restocking**");
				System.out.println("-----------------------------------------------------------------");
				System.out.println("Store Inventory");
				System.out.println("-----------------------------------------------------------------");
				System.out.println(items.get(0).getName()+": "+items.get(0).getQuantity()+", "+items.get(1).getName()+": "+items.get(1).getQuantity()+", "+items.get(2).getName()+": "+items.get(2).getQuantity()+", "+items.get(3).getName()+": "+items.get(3).getQuantity()+", "+items.get(4).getName()+": "+items.get(4).getQuantity());
				System.out.println("-----------------------------------------------------------------");
				System.out.println();
			}
			/*
			 * notify to all threads which are waiting for the store object.
			 */
			store.notifyAll();
		}
		}
	}
}