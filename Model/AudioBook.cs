public class AudioBook {
    public int bookId {get; set;} // Nanti isinya pake isbn, jangan generate
    public int audiobookId  {get; set;} // Nanti isinya auto increment
    public string? audioDatePublished {get; set;} // Date publishednya berbeda dengan Buku Fisik
}