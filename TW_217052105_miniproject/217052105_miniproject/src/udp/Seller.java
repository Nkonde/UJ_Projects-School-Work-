package udp;


import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;
import java.util.ArrayList;


import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.control.Button;
import javafx.scene.control.DatePicker;
import javafx.scene.control.Label;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.layout.GridPane;


public class Seller extends GridPane{
	
	
	private DatagramSocket clientSocket= null;
	private DatagramSocket serverSocket = null;
	private InetAddress IPAdress = null;
	private int port = 0;

	
	
	
	

	//GUI elements 
	
	Label lblCompanyName = new Label("Company Name"); 
	TextField txtCompanyName = new TextField(); 
	
	Label lblItemID = new Label("Item ID"); 
	TextField txtItemID = new TextField(); 
	
	Label lblItemName = new Label("Item Name"); 
	TextField txtItemName = new TextField(); 
	
	Label lblItemDescription = new Label("Item Description"); 
	TextField txxAdescrip=new TextField(); 
	
	
	 Label lblDate = new Label("Date Uploaded");  
     DatePicker datePicker = new DatePicker(); 
     
     Button buttonRegister = new Button("Sell Item");
     
     Button btnConctS = new Button("Connect");
     
     
	Seller() {
		setAdmin();
    	
		}
	
	
	
	//Set up GUI for Company
	public void setAdmin() {
		
	      //Setting the padding    
	      setPadding(new Insets(10, 10, 10, 10));  
	      
	      //Setting the vertical and horizontal gaps between the columns 
	      setVgap(5); 
	      setHgap(5);       
	      
	      //Setting the Grid alignment 
	      setAlignment(Pos.CENTER); 
	       
	      
	      Label lblmaillabel = new Label("Company (Store)");
	      lblmaillabel.setAlignment(Pos.CENTER);
	      
	      add(lblmaillabel, 0, 0); 
	      //Arranging all the nodes in the grid 
	      add(lblCompanyName, 0, 1); 
	      add(txtCompanyName, 1,1); 
	       
	      add(lblItemID, 0, 2);       
	      add(txtItemID, 1, 2); 
	      
	      add(lblItemName, 0, 3); 
	      add(txtItemName, 1, 3); 
	      
	      
	      add(lblDate, 0, 4); 
	      add(datePicker, 1, 4); 
	      
	      
	      add(lblItemDescription, 0, 5); 
	      add(txxAdescrip, 1, 5); 
	      
	      add(btnConctS,0,6);
	      btnConctS.setOnAction(e->{
	    	 
	    	  try {
					serverSocket = new DatagramSocket(2020);
					byte[] receiveData = new byte[1024];
					
					DatagramPacket connectPacket = new DatagramPacket(receiveData, receiveData.length);
					try {
						serverSocket.receive(connectPacket);
					} catch (IOException e1) {
						e1.printStackTrace();
					}
					
					//convert data
					String connectionString = new String(connectPacket.getData());
					System.out.println(connectionString);
					
					//get client data
					IPAdress = connectPacket.getAddress();
					port = connectPacket.getPort();
					System.out.println("Server is running");
				} catch (SocketException e1) {
					System.err.println("Cannot bind to  port");
				}
	      });
	      add(buttonRegister, 0, 8); 
	      buttonRegister.setOnAction(e->{
	    	 // String data=(txtItemName.getText());
	    	//  ArrayList<Block> blockchain=new ArrayList<>();
	    	//  Block blck=new Block(blockchain.size(),data,2);
	    	//  txxAdescrip.appendText(blck.toString());
	    	  AddInfoToBlock();
	      });
	    	 
	     
	      lblmaillabel.setStyle("-fx-font: normal bold 30px 'Courier New' ");
	      lblCompanyName.setStyle("-fx-font: normal bold 13px 'Courier New' "); 
	      lblItemID.setStyle("-fx-font: normal bold 13px 'Courier New' "); 
	      lblItemName.setStyle("-fx-font: normal bold 13px 'Courier New' ");
	      lblDate.setStyle("-fx-font: normal bold 13px 'Courier New' ");
	      lblItemDescription.setStyle("-fx-font: normal bold 13px 'Courier New' ");
	    
	      //Setting the back ground color 
	     // setStyle("-fx-background-color: #5bc0de;"); 
	      
	      }  
	       
	      
public void AddInfoToBlock() {
		
		
		
	
		
		//send the actual data
		sendData(txtCompanyName.getText() +" "+ txtItemID.getText()+""+lblItemName.getText()+""+txxAdescrip.getText());

		System.out.println("File sent!!");
		
		
	}
private void sendData(String line) {
	
	byte[] itemData = new byte[1024];
	itemData = line.getBytes();
	DatagramPacket listPacket = new DatagramPacket(itemData, itemData.length, IPAdress, port);
	
	try {
		serverSocket.send(listPacket);
	} catch (IOException e) {
		System.err.println("Cannot send file list \n");
		e.printStackTrace();
	}
}



public TextField getTxtCompanyName() {
	return txtCompanyName;
}



public void setTxtCompanyName(TextField txtCompanyName) {
	this.txtCompanyName = txtCompanyName;
}



public TextField getTxtItemID() {
	return txtItemID;
}



public void setTxtItemID(TextField txtItemID) {
	this.txtItemID = txtItemID;
}



public TextField getTxtItemName() {
	return txtItemName;
}



public void setTxtItemName(TextField txtItemName) {
	this.txtItemName = txtItemName;
}



public DatePicker getDatePicker() {
	return datePicker;
}



public void setDatePicker(DatePicker datePicker) {
	this.datePicker = datePicker;
}

}
