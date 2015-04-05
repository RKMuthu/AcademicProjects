


public class Simulator {
	/**
	 * Create 5 customer threads which constantly request for items in the store and 1 manager threads
	 * which constantly restocks the inventory when the item is depleted
	 * @param args
	 */
	public static void main(String[] args) {
	Store obj=new Store();
	CustomerRunnable customer1=new CustomerRunnable(obj); 
	new Thread(customer1,"customer1").start();
	CustomerRunnable customer2=new CustomerRunnable(obj); 
	new Thread(customer2,"customer2").start();
	CustomerRunnable customer3=new CustomerRunnable(obj);
	new Thread(customer3,"customer3").start();
	CustomerRunnable customer4=new CustomerRunnable(obj);
	new Thread(customer4,"customer4").start();
	CustomerRunnable customer5=new CustomerRunnable(obj);
	new Thread(customer5,"customer5").start();
	ManagerRunnable manager=new ManagerRunnable(obj);
	new Thread(manager,"Manager").start();
}
}
