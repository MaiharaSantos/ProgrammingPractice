/* *****************************************************************************
 *  Name: Maihara Gabrieli Santos
 *  Date: 03/06/2020
 *  Description: Percolation API
 **************************************************************************** */

public class Percolation {
    private int[][] grid;
    private int size;
    private int numOfOpenSites;

    // creates n-by-n grid, with all sites initially blocked
    public Percolation(int n) {
        if (n < 1) {
            throw new IllegalArgumentException("n: " + n);
        }
        this.size = n;
        this.numOfOpenSites = 0;
        this.grid = new int[n][n];
        for (int row = 0; row < n; row++) {
            for (int col = 0; col < n; col++) {
                grid[row][col] = 1;
            }
        }
    }

    // opens the site (row, col) if it is not open already
    public void open(int row, int col) {
        if (row < 1 || row > size || col < 1 || col > size) {
            throw new IllegalArgumentException("row: " + row + " col: " + col);
        }
        //TODO: check if is better throw a exception if grid[row][col] is open
        grid[row][col] = 0;
    }

    // is the site (row, col) open?
    public boolean isOpen(int row, int col) {
        if (row < 1 || row > size || col < 1 || col > size) {
            throw new IllegalArgumentException("row: " + row + " col: " + col);
        }
        return (grid[row][col] == 0);
    }

    // is the site (row, col) full?
    public boolean isFull(int row, int col) {
        if (row < 1 || row > size || col < 1 || col > size) {
            throw new IllegalArgumentException("row: " + row + " col: " + col);
        }
        return (grid[row][col] == 1);
    }

    // returns the number of open sites
    public int numberOfOpenSites() {
        return numOfOpenSites;
    }

    // does the system percolate?
    public boolean percolates()

    // test client (optional)
    public static void main(String[] args)
}
