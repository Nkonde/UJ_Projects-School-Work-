package file;

import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

import blockchain.BlockChain;
import udp.Records;

public class BlockFileHandler {
	
	public static void writeRecordstoFile(Records p) {
		ObjectOutputStream oos = null;
		
		try {
			BufferedOutputStream bos = new BufferedOutputStream(new FileOutputStream(new File("./data/record.txt")));
			oos = new ObjectOutputStream(bos);
			oos.writeObject(p);
		} catch (IOException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}finally {
			if(oos != null) {
				try {
					oos.close();
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}}	
		}
		
		public static void newBlock(File file, BlockChain chain) {
			if(file.exists()) {
			
			//replace chain file with file
			ObjectOutputStream oos = null;
			try {
				FileOutputStream fos = new FileOutputStream(file, false);
				BufferedOutputStream bos = new BufferedOutputStream(fos);
				oos = new ObjectOutputStream(bos);
			
				//save chain to file
				oos.writeObject(chain);
					
				
			}catch(IOException ex) {
				System.err.println("Unable to write to File: " + file.getAbsolutePath());
			}finally {
				if(oos != null) {
					try {
						//Close the file
						oos.close();
					}catch(IOException ex) {
						System.err.println("Unable to close File: " + file.getAbsolutePath());
					
					}
				}
			}
			
			
			}else {
				System.err.println("File not found");
			}
			
		
		
	}
		
		public static BlockChain InsertIntoBlock(File file) {
			BlockChain temp = new BlockChain();
			ObjectInputStream ois = null;
			try {
				FileInputStream fin = new FileInputStream(file);
				BufferedInputStream bin = new BufferedInputStream(fin);
				ois = new ObjectInputStream(bin);
				//Read file to chain
				Object obj = ois.readObject();
				if(obj instanceof BlockChain) {
					//cast object to block chain
					temp = (BlockChain)obj;
				}
			}catch(IOException x) {
				System.err.println("Unable to open File: " + file.getAbsolutePath());
			}catch(ClassNotFoundException ex) {
				System.err.println("Unable to open File: " + file.getAbsolutePath());
			}finally {
				if(ois != null) {
					try {
						//Close the file
						ois.close();
					}catch(IOException ex) {
						System.err.println("Unable to open File: " + file.getAbsolutePath());
					}
				}
			}
			return temp;
		}
		
	
	
	
	

}
