package udp;





import java.net.DatagramSocket;
import java.net.InetAddress;


import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.layout.GridPane;
import javafx.scene.text.Font;
import javafx.scene.text.FontWeight;
import javafx.stage.Stage;

public class SceneController extends GridPane{

	private Button btnSeller;
	private Button btnBuyer;
	
	
	private DatagramSocket clientSocket= null;
	private DatagramSocket serverSocket = null;
	private InetAddress IPAdress = null;
	private int port = 0;
	
	public SceneController(Stage stage){
		setLandingPage();
		btnSeller.setOnAction((e->{
			

			stage.setScene(new Scene(new Seller(),500,500));
			
		}));
		
		btnBuyer.setOnAction(e->{
			
			stage.setScene(new Scene(new Buyer(),500,500));
			
		});
	}
	public void setLandingPage() {
		setVgap(10);
		setHgap(10);
    	Label theaderLabel = new Label("Choose Mode:");
   	 setAlignment(Pos.CENTER);
		theaderLabel.setFont(Font.font("Arial", FontWeight.BOLD, 16));
	 
		btnSeller=new Button("Sell Item");
		btnBuyer = new Button("Buy Item");
		
		add(theaderLabel, 0,1);
		add(btnSeller, 0, 2);
		add(btnBuyer, 0, 3);
		
		
		
	}
	
}
