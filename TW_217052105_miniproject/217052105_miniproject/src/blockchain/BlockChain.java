package blockchain;

import java.io.Serializable;
import java.util.ArrayList;

import udp.Records;

public class BlockChain implements Serializable{
	/**
	 * Attributes
	 */
	private static final long serialVersionUID = 1L;
	private ArrayList<Block> ChainOfRecords = new ArrayList<Block>();
	private ArrayList<Block> PendingRecords = new ArrayList<Block>();
	int Size= 0;

	//Constructor
	public BlockChain() {}
	
	//creating the first block in the block chain
	private Block CreateGenesisBlock() {
		Block b = new Block("0","GenesisBlock",new Records(),3);
		b.setHash("000");
		return b;
	}
	
	//Retrieving the latest block in the block
	public Block GetLatestBlock() {
		return ChainOfRecords.get(this.size() - 1);
	}
	
	//Check chains integrity
	public  Boolean validChain() {
		for(int i=Size-1; i>0; i--) {
			Block latestBlock = GetLatestBlock();
			Block previousBlock = ChainOfRecords.get(i - 1);
			if(!(latestBlock.PreviousHash.equals(previousBlock.hash))) {
				System.out.println("Latest block previous hash doesn't match previous block hash");
				return false;
			}
		}
		return true;
	}
	
	//Adding a new block to the block chain
	public void AddBlock(Block newBlock) {
		newBlock.hash = newBlock.mineBlock(newBlock.calculateHash());
		ChainOfRecords.add(newBlock);
		Size++;
	}

	//checking if the chain is empty
	public boolean isEmpty() {
		// TODO Auto-generated method stub
		if(Size == 0) {
			return true;
		}
		return false;
	}
	
	//validating the latest added block and adding the block to the block chain
    public void ValidateBLock() {
    	Block BlockValidated = PendingRecords.get(PendingRecords.size() - 1);
    	if(BlockValidated.getPreviousHash().equals(GetLatestBlock().getHash())){
    		ChainOfRecords.add(BlockValidated);
    		PendingRecords.remove(PendingRecords.size() - 1);
    		Size++;

    	}
    }
    
    public ArrayList<Block> getChainOfRecords() {
		return ChainOfRecords;
	}

	public void setChainOfRecords(ArrayList<Block> chainOfRecords) {
		ChainOfRecords = chainOfRecords;
	}

	public void setSize(int size) {
		Size = size;
	}
    
    //getting the size of the block chain
	public int size() {
		return Size;
	}
	
	public String toString() {
		String result = "";
		for(int b = 0; b < this.size();b++){
			result += ChainOfRecords.get(b).toString()+"";
		}
		return result;
	}
}
