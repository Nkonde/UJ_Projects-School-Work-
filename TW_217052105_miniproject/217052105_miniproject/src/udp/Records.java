package udp;

import java.io.Serializable;

public class Records implements Serializable{
	
	

	private String CompanyName = null;
	private String ItemID = null;
	private String ItemName = null;
	private String ItemDescription = null;
	private double ItemPrice = 0;
	
	
	
	public  Records() {
		
	};
	public Records(String companyName, String itemID, String itemName, String itemDescription, double itemPrice) {
		this.CompanyName = companyName;
		this.ItemID = itemID;
		this.ItemName = itemName;
		this.ItemDescription = itemDescription;
		this.ItemPrice = itemPrice;
	}

	

	public String getCompanyName() {
		return CompanyName;
	}

	public String getItemID() {
		return ItemID;
	}

	public String getItemName() {
		return ItemName;
	}

	public String getItemDescription() {
		return ItemDescription;
	}

	public double getItemPrice() {
		return ItemPrice;
	}

	public void setCompanyName(String companyName) {
		CompanyName = companyName;
	}

	public void setItemID(String itemID) {
		ItemID = itemID;
	}

	public void setItemName(String itemName) {
		ItemName = itemName;
	}

	public void setItemDescription(String itemDescription) {
		ItemDescription = itemDescription;
	}

	public void setItemPrice(double itemPrice) {
		ItemPrice = itemPrice;}
	
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		String display = "";
		display += "Company Name: " + CompanyName + "\n";
		display += "Item ID: " + ItemID + "\n";
		display += "Item Name: " + ItemName + "\n";
		display += "Item Description : " + ItemDescription + "\n";
		display += "Item Price:" + ItemPrice + "\n";
		
		return display;
	}

}
