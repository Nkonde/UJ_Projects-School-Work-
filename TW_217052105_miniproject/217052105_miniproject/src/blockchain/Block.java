package blockchain;

import java.io.Serializable;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.time.Instant;
import java.util.Date;

import udp.Records;

public class Block implements Serializable {
	//Attributes
	public String Index;
	public String hash;
	public String PreviousHash;
	public long TimeStamp;
	private Records data;
	private int nonce;
	private int Difficulty;
	
	//default constructor
	public Block() {
		Index = " ";
		PreviousHash = " ";
		this.TimeStamp = 0;
		this.data = null;
		Difficulty = 0;
	}
	//Block constructor
	public Block(String index, String previousHash, Records data,int difficulty) {
		Index = index;
		PreviousHash = previousHash;
		this.TimeStamp = Instant.now().toEpochMilli();
		this.data = data;
		Difficulty = difficulty;
		this.hash = mineBlock(calculateHash());
	}
	
	//getters for block
	public long getTimeStamp() {
		return TimeStamp;
	}

	public String getPreviousHash() {
		return PreviousHash;
	}

	public String getHash() {
		return hash;
	}
	
	public String getIndex() {
		return Index;
	}
	
	public Records getData() {
		return data;
	}
	
	public int getDifficulty() {
		return Difficulty;
	}

	//setter for the block
	public void setHash(String hash) {
		this.hash = hash;
	}
	
	public void setIndex(String index) {
		Index = index;
	}
	
	public void setTimeStamp(long timeStamp) {
		TimeStamp = timeStamp;
	}

	public void setPreviousHash(String previousHash) {
		PreviousHash = previousHash;
	}

	public void setDifficulty(int difficulty) {
		Difficulty = difficulty;
	}

	//Helper function for calculating the hash
	public String calculateHash() {
		String stringtoHash = PreviousHash + Long.toString(TimeStamp) + data + nonce;
		String hashedString = CalculateHash(stringtoHash);
		return hashedString;
	}
	
	//function for mining block
	public String mineBlock(String hash) {
		//Create a string with leading zeros
		String target = new String(new char[Difficulty]).replace('\0', '0');
		System.out.println("Block number : " + Index);
		//Each time no match for hash, add increase nonce and add to the string to hash.
		while(!hash.substring(0, Difficulty).equals(target)) {
			nonce++;
			hash = calculateHash();
			System.out.println("hash : " + hash);
		}
		System.out.println("Block Mined!!! : " + hash+"\n");
		return hash;
	}
	
	//helper function for calculating hash
	private String CalculateHash(String TobeHashed) {
		try {
			MessageDigest mdigest;
			mdigest = MessageDigest.getInstance("SHA-256");
			mdigest.update(TobeHashed.getBytes());
						
			StringBuffer hexString = new StringBuffer(); 
			
			//Convert from byte to hex string format
	        for (byte byt : mdigest.digest()) {
	        	hexString.append(Integer.toString((byt & 0xff) + 0x100, 16).substring(1));
	        }
			
	        return hexString.toString();

		} catch (NoSuchAlgorithmException e) {
			e.printStackTrace();
			return " ";
		}
	}
	
	//function for displaying string representation of block
	public String toString() {
		if (hash.equals(":")) {
			return " ";
		}
		return  Index + "," + hash + "," + PreviousHash + "," + TimeStamp;
	}
	
}
