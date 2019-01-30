﻿using System.Data.SqlClient;

namespace AnyCompany
{
    internal class OrderRepository
    {
        public void Save(Order order)
        {
            SqlConnection connection = new SqlConnection(ConnectionStrings.OrdersConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Orders VALUES (@OrderId, @Amount, @VAT)", connection);

            command.Parameters.AddWithValue("@OrderId", order.OrderId);
            command.Parameters.AddWithValue("@Amount", order.Amount);
            command.Parameters.AddWithValue("@VAT", order.VAT);

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}