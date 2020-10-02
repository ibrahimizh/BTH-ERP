namespace ERP.API.Data.Queries
{
    public static class ProposalQueries
    {
        public static readonly string GetAllProposals= @"select wo.id 'WorkOrderId',p.* 
                                                        from work_orders wo 
                                                        right outer join v_proposals p
                                                        on wo.proposalid=p.id order by p.Timestamp desc;";

        public static readonly string GetProposalById= @"select wo.id 'WorkOrderId',p.*,p.VAT  
                                                        from work_orders wo 
                                                        right outer join v_proposals p
                                                        on wo.proposalid=p.id where p.id=@id;";

        public static readonly string AddProposal= @"INSERT INTO proposals
                                                    (
                                                    Timestamp,
                                                    Description,                                                    
                                                    ContactMode,
                                                    BusinessPartnerId,
                                                    BusinessPartnerContactId,
                                                    Discount,
                                                    VAT
                                                    ) 
                                                     VALUES
                                                     (
                                                    NOW(),
                                                    @Description,                                                    
                                                    @ContactMode,
                                                    @BusinessPartnerId,
                                                    @BusinessPartnerContactId,
                                                    @Discount,
                                                    @VAT
                                                    );SELECT LAST_INSERT_ID();";

        public static readonly string ConfirmProposal= @"update `erp`.`proposals` set WorkOrderId=@WorkOrderId where Id=@Id;";

        public static readonly string AddProposalItem = @"INSERT INTO `erp`.`proposal_items`
                                                        (
                                                        `ProposalId`,
                                                        `Item`,
                                                        `Specification`,
                                                        `Quantity`,
                                                        `UnitPrice`)
                                                        VALUES
                                                        (
                                                        @ProposalId,
                                                        @Item,
                                                        @Specification,
                                                        @Quantity,
                                                        @UnitPrice);

                                                        UPDATE `erp`.`proposals` SET TotalAmount=TotalAmount+(@Quantity*@UnitPrice) 
                                                        Where Id=@ProposalId;";

        public static readonly string GetQuoteItems = @"select w.Discount,wi.*,(wi.Quantity * wi.UnitPrice) LineTotal,w.VAT from `erp`.proposal_items wi
                                                        left outer join `erp`.proposals w
                                                        on wi.proposalid=w.id
                                                        where wi.proposalid=@ProposalId;";

        public static readonly string UpdateProposalItems = @"UPDATE `erp`.`proposal_items`
                                                        SET 
                                                        `Item`=@Item,
                                                        `Specification`=@Specification,
                                                        `Quantity`=@Quantity,
                                                        `UnitPrice`=@UnitPrice WHERE Id=@Id;";

        public static readonly string UpdateQuote = @"UPDATE `erp`.`proposals` SET TotalAmount=@TotalAmount,Discount=@Discount,QuoteRevisionNo=QuoteRevisionNo+1 
                                                        Where Id = @ProposalId;";
        public static readonly string GetQuoteRevisionNo = @"SELECT QuoteRevisionNo FROM `erp`.`proposals` WHERE Id = @ProposalId";
        public static readonly string DeleteProposalItem = @"DELETE FROM `erp`.`proposal_items` where Id=@Id";

        

    }
}