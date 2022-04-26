package udp;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;
import java.net.UnknownHostException;
import java.util.StringTokenizer;

import blockchain.Block;
import blockchain.BlockChain;
import file.BlockFileHandler;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.control.Button;
import javafx.scene.control.DatePicker;
import javafx.scene.control.Label;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.layout.GridPane;

public class Buyer extends GridPane{
	
	
	
	Label lblbuyername = new Label("Buyer Name"); 
	TextField txtCompanyName = new TextField(); 
	
	Label lblBuyerID = new Label("Buyer ID"); 
	TextField txtBuyerID = new TextField(); 
	
	Label lblviewItem = new Label("Item Details"); 
	
	TextArea txtArea= new TextArea();
	 Label lblDate = new Label("Buyer DOB");  
     DatePicker datePicker = new DatePicker(); 
     
     Button btnBuyItem = new Button("Buyer");  
     Button btnVerifyItem = new Button("Verify Block");  
     Button btnnewBlock = new Button("Get New Block");  
	 
 	private DatagramSocket clientSocket= null;
 	private DatagramSocket serverSocket = null;
 	private InetAddress IPAdress = null;
 	private int port = 0;
    private Records s;
    private TextArea txtblock = new TextArea();
    private BlockChain blockchain = new BlockChain();
    private Block newBlock;
    private Button btnShare = new Button("share Block Details ");
 	Button btnConnectB=new Button("Connect");
	Buyer(){
		
		setClient();
	
		
	}
	

	public void setClient() {
		
	
		 //Setting the padding    
	      setPadding(new Insets(10, 10, 10, 10));  
	      
	      //Setting the vertical and horizontal gaps between the columns 
	      setVgap(5); 
	      setHgap(5);       
	      
	      //Setting the Grid alignment 
	      setAlignment(Pos.CENTER); 
	       
	      
	      Label lblmaillabel = new Label("Customer)");
	      lblmaillabel.setAlignment(Pos.CENTER);
	      
	      add(lblmaillabel, 0, 0); 
	      //Arranging all the nodes in the grid 
	      
	      add(lblviewItem, 0, 1); 
	      add(txtArea, 1, 1); 
	      add(btnConnectB, 0, 2); 
	      add(btnBuyItem, 0, 3); 
	      add(btnVerifyItem, 0, 4); 
	      add(txtblock,0,5);
	      add(btnnewBlock, 0, 6); 
	      
	      lblmaillabel.setStyle("-fx-font: normal bold 30px 'Courier New' ");
	      lblviewItem.setStyle("-fx-font: normal bold 13px 'Courier New' "); 
	      
	      btnConnectB.setOnAction(e->{
	    	  
	    		try {
					clientSocket = new DatagramSocket();
					
					byte[] sendData = ("Send Item").getBytes();
					
					
					try {
						IPAdress = InetAddress.getLocalHost();
					} catch (UnknownHostException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
					//send greeting
					DatagramPacket sendPacket = new DatagramPacket(sendData, sendData.length, IPAdress, 2020);
					try {
						clientSocket.send(sendPacket);
						
					} catch (IOException e1) {
						System.err.println("Cannot send connection string");
						e1.printStackTrace();
					}
				} catch (SocketException e1) {
					System.err.println("Cannot connect to server");
					e1.printStackTrace();
				}
	      });
	      
	      btnBuyItem.setOnAction(e->{
	    	  
	    		try {
	    			
	    				//Information About transaction 
	    				byte[] filedata = new byte[1024];
	    				
	    				DatagramPacket DataPacket = new DatagramPacket(filedata, filedata.length);
	    				clientSocket.receive(DataPacket);
	    				
	    				//read response to string
	    				String line = new String(DataPacket.getData());
	    				
	    				StringTokenizer tkn = new StringTokenizer(line);
	    				
	    				
	    				//string tokenizer
	    				
	    				String compName = tkn.nextToken();
	    				String ItemID = tkn.nextToken();
	    				String itna = tkn.nextToken();
	    			
	    				
	    				
	    				s=new Records();
	    				s.setCompanyName(compName);
	    				s.setItemID(ItemID);
	    				s.setItemName(itna);
	    				s.setItemDescription(itna);
	    				txtArea.appendText(s.toString());
	    				if(blockchain.isEmpty()) {
	    					newBlock = new Block(blockchain.size()+"","genesis block",s,3);
	    					blockchain.AddBlock(newBlock);
	    				}
	    				newBlock = new Block(blockchain.size()+"",blockchain.GetLatestBlock().hash,s,3);
	    				blockchain.AddBlock(newBlock);
	    				
	    				BlockFileHandler.writeRecordstoFile(s);
	    				
	    			
	    			
	    			
	    			
	    		} catch (IOException e1) {
	    			System.err.println("Cannot read response");
	    			e1.printStackTrace();
	    		}
	    		
	    		
	    		
	    	
	      });
	      
	      btnVerifyItem.setOnAction(e->{
	    	  
	  		
	    	  txtblock.appendText(newBlock.toString());
	  		
	  		
	      });
	      
	      btnShare.setOnAction(e->{
	    	  
	      });
	      
	      
  		
	}
	private void sendData(String line) {
		
		byte[] itemData = new byte[1024];
		itemData = line.getBytes();
		DatagramPacket listPacket = new DatagramPacket(itemData, blockchain.hashCode());
		
		try {
			serverSocket.send(listPacket);
		} catch (IOException e) {
			System.err.println("Cannot send file list \n");
			e.printStackTrace();
		}
	}
}

	    
	
