﻿namespace BlazorInvoiceApp.DTOS;

public class InvoiceTermDTO : IDTO, IOwnedDTO
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = String.Empty;
    public string UserId { get; set; } = null!;
}
