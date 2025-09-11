public class Trip
{
	public string Id { get; set; }  // ID generado por Firebase
	public string UserId { get; set; } // ID del usuario
	public string Title { get; set; }
	public string DestinationCountry { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public string Status { get; set; } // "Planificado" o "Completado"
	public string Description { get; set; }
}
