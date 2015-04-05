public	class	Item	
{	
			private	String	name;	
			private	int	quantity;	
			private int tempQuantity;
		/**
		 * Constructor for initializing the name and quantity of the item
		 * @param aName
		 */
			public	Item(String	aName)	
			{	
						this(aName,	0);	
			}	
				
			public	Item(String	aName,	int	aQuantity)	
			{	
						name	=	aName;	
						quantity	=	aQuantity;	
						tempQuantity=aQuantity;
			}
			/**
			 * Getters and Setters for the name,quantity and tempquantity
			 * @return
			 */
			
			public	String	getName()	
			{	
						return	name;	
			}	
				
			public	int	getQuantity()	
			{	
						return	quantity;	
			}	
				
			public	void	setQuantity(int	newQuantity)	
			{	
						quantity	=	newQuantity;	
			}	
				
			public	boolean	equals(Item item)	
			{	
						if	(item.getClass()	!=	this.getClass())	
									return	false;	
						Item	other	=	(Item) item;	
						if	(other.getName().equals(name))	
									return	true;	
						return	false;				}
			public int getTempQuantity() {
				return tempQuantity;
			}

			public void setTempQuantity(int tempQuantity) {
				this.tempQuantity = tempQuantity;
			}
}	

