﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LightAndLensCL.Models;
using Microsoft.EntityFrameworkCore;

namespace LightAndLens_FormApp
{


    public partial class RentalRequests : Form
    {

        LightAndLensDBContext context;

        public RentalRequests()
        {
            InitializeComponent();
            context = new LightAndLensDBContext();

            txtSearchCustOrEq.Enter += new EventHandler(txtSearchCustOrEq_Enter);
            txtSearchCustOrEq.Leave += new EventHandler(txtSearchCustOrEq_Leave);

            dgvRentalRequests.SelectionChanged += dgvRentalRequests_SelectionChanged;

            // adding click event handlers for the approve and reject buttons
            btnApprove.Click += btnApprove_Click;
            btnReject.Click += btnReject_Click;

            HighlightActiveButton(rentalRequestsBtn);

        }






        private void RentalRequests_Load(object sender, EventArgs e)
        {

            try
            {
                dgvRentalRequests.DataSource = context.RentalRequests.ToList();


                txtSearchCustOrEq.Text = "Search by customer or equipment...";
                txtSearchCustOrEq.ForeColor = Color.Gray;



                cmbStatusFilter.DataSource = context.RequestStatuses.ToList();
                cmbStatusFilter.DisplayMember = "StatusName";
                cmbStatusFilter.ValueMember = "RequestStatusID";
                //cmbStatusFilter.ValueMember = "StatusName";
                //cmbStatusFilter.SelectedValue = null;



                //ddlFilterCustomer.DataSource = context.Customers.ToList(); ;

                //ddlFilterCustomer.DisplayMember = "ContactName";
                //ddlFilterCustomer.ValueMember = "CustomerID";
                //ddlFilterCustomer.SelectedItem = null;
            }
            catch (Exception)
            {

                throw; //in this case, we are throwing the exception so you can debug. Later, you should catch it and display and error messageusing MessageBox.Show(ex.Message);  
            }

            RefreshRequestsGridview();
            clearFilters();
            labelUserName.Text = Session.CurrentUser.UserName;
        }

        private void FilterRequestsGridview()
        {

            try
            {

                dgvRentalRequests.DataSource = null;

                var RentalRequestsToShow = context.RentalRequests.AsQueryable(); //get all if no filter is selected
                                                                                 //AsQuerable() is needed since the output from Orders without the extention methods is just DBSet,
                                                                                 //while the filter extention methods below require and return an IQuerable type

                // 1 = Pending
                // 2 = Approved
                // 3 = Rejectes
                if (cmbStatusFilter.SelectedValue != null)
                {

                    if ((int)cmbStatusFilter.SelectedValue == 1)
                    {

                        RentalRequestsToShow = RentalRequestsToShow.Where(x => x.RequestStatus.RequestStatusId == 1);

                    }
                    else if ((int)cmbStatusFilter.SelectedValue == 2)
                    {

                        RentalRequestsToShow = RentalRequestsToShow.Where(x => x.RequestStatus.RequestStatusId == 2);

                    }
                    else if ((int)cmbStatusFilter.SelectedValue == 3)
                    {

                        RentalRequestsToShow = RentalRequestsToShow.Where(x => x.RequestStatus.RequestStatusId == 3);

                    }
                }


                DateTime fromDate = dateTimePickerFrom.Value.Date;
                DateTime toDate = dateTimePickerTo.Value.Date;

                // Ensure toDate includes the whole day
                toDate = toDate.AddDays(1).AddSeconds(-1);

                // Apply date filter
                RentalRequestsToShow = RentalRequestsToShow
                    .Where(r => r.RequestSetDate >= fromDate && r.RequestSetDate <= toDate);



                dgvRentalRequests.DataSource = RentalRequestsToShow
                    .Include(r => r.User)
                    .Include(r => r.Equipment)
                    .Include(r => r.RequestStatus)
                    .OrderByDescending(r => r.RequestSetDate)
                    .Select(r => new
                    {
                        r.RequestId,
                        FullName = r.User.FullName,
                        EquipmentName = r.Equipment.EquipmentName,
                        r.RequestStartDate,
                        r.RequestEndDate,
                        Status = r.RequestStatus.StatusName,
                        r.RequestSetDate
                    })
                    .ToList();

                //to pass the request id and make it unVisible
                dgvRentalRequests.Columns["RequestId"].Visible = false;

            }
            catch (Exception)
            {

                throw; //in this case, we are throwing the exception so you can debug. Later, you should catch it and display and error messageusing MessageBox.Show(ex.Message);  
            }
        }
        private void RefreshRequestsGridview()
        {
            try
            {

                dgvRentalRequests.DataSource = null;

                var RentalRequestsToShow = context.RentalRequests.AsQueryable(); //get all if no filter is selected
                                                                                 //AsQuerable() is needed since the output from Orders without the extention methods is just DBSet,
                                                                                 //while the filter extention methods below require and return an IQuerable type

                // 1 = Pending
                // 2 = Approved
                // 3 = Rejectes
                //if (cmbStatusFilter.SelectedValue != null)
                //{

                //    if ((int)cmbStatusFilter.SelectedValue == 1)
                //    {

                //        RentalRequestsToShow = RentalRequestsToShow.Where(x => x.RequestStatus.RequestStatusId == 1);

                //    }
                //    else if ((int)cmbStatusFilter.SelectedValue == 2)
                //    {

                //        RentalRequestsToShow = RentalRequestsToShow.Where(x => x.RequestStatus.RequestStatusId == 2);

                //    }
                //    else if ((int)cmbStatusFilter.SelectedValue == 3)
                //    {

                //        RentalRequestsToShow = RentalRequestsToShow.Where(x => x.RequestStatus.RequestStatusId == 3);

                //    }
                //}



                //if (txtFilterOrderNo.Text != "")
                //{
                //    ordersToShow = ordersToShow
                //        .Where(x => x.OrderId == Convert.ToInt32(txtFilterOrderNo.Text));
                //    //if order id is specified in the filters, get the order with that id
                //}

                //else if (ddlFilterCustomer.SelectedValue != null)
                //{
                //    ordersToShow = ordersToShow
                //        .Where(x => x.CustomerId == ddlFilterCustomer.SelectedValue.ToString());
                //    //if customer is selected from the combobox, get orders of that customer
                //}



                dgvRentalRequests.DataSource = RentalRequestsToShow
                    .Include(r => r.User)
                    .Include(r => r.Equipment)
                    .Include(r => r.RequestStatus)
                    .OrderByDescending(r => r.RequestSetDate)
                    .Select(r => new
                    {
                        r.RequestId,
                        FullName = r.User.FullName,
                        EquipmentName = r.Equipment.EquipmentName,
                        r.RequestStartDate,
                        r.RequestEndDate,
                        Status = r.RequestStatus.StatusName,
                        r.RequestSetDate
                    })
                    .ToList();

                // to pass the request id and make it unVisible
                dgvRentalRequests.Columns["RequestId"].Visible = false;

            }
            catch (Exception)
            {

                throw; //in this case, we are throwing the exception so you can debug. Later, you should catch it and display and error messageusing MessageBox.Show(ex.Message);  
            }
        }


        private void clearFilters()
        {
            txtSearchCustOrEq.Text = "Search by customer or equipment...";
            txtSearchCustOrEq.ForeColor = Color.Gray;

            cmbStatusFilter.SelectedItem = null;
            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerTo.Value = DateTime.Now;
            RefreshRequestsGridview();
        }

        private void txtSearchCustOrEq_Enter(object sender, EventArgs e)
        {
            if (txtSearchCustOrEq.Text == "Search by customer or equipment...")
            {
                txtSearchCustOrEq.Text = "";
                txtSearchCustOrEq.ForeColor = Color.Black;
            }
        }


        private void txtSearchCustOrEq_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchCustOrEq.Text))
            {
                txtSearchCustOrEq.Text = "Search by customer or equipment...";
                txtSearchCustOrEq.ForeColor = Color.Gray;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbStatusFilter.SelectedValue.ToString());
            FilterRequestsGridview();
            //RefreshRequestsGridview();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFilters();
        }


        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvRentalRequests.SelectedRows.Count > 0)
            {
                try
                {
                    int requestId = Convert.ToInt32(dgvRentalRequests.SelectedRows[0].Cells["RequestId"].Value);
                    var rentalRequest = context.RentalRequests
                                               .Include(r => r.User)
                                               .Include(r => r.Equipment)
                                               .FirstOrDefault(r => r.RequestId == requestId);

                    if (rentalRequest != null)
                    {
                        // Update request status to Approved (1)
                        rentalRequest.RequestStatusId = 1;

                        // Create new RentalTransaction from this approved request
                        var rentalTransaction = new RentalTransaction
                        {
                            RequestId = rentalRequest.RequestId,
                            UserId = rentalRequest.UserId,
                            StartDate = rentalRequest.RequestStartDate,
                            EndDate = rentalRequest.RequestEndDate,
                            RentalFee = 50m,
                            DepositPaid = 50m,
                            Status = "Ongoing"
                        };

                        context.RentalTransactions.Add(rentalTransaction);

                        context.SaveChanges();

                        MessageBox.Show("Request approved and rental transaction created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshRequestsGridview(); // Refresh the requests grid
                                                   // You may want to call RefreshTransactionsGridview() here if you have it to update transactions grid
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error approving request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            UpdateRequestStatus(3); // 3 = Rejected
        }

        private void UpdateRequestStatus(int newStatusId)
        {
            if (dgvRentalRequests.SelectedRows.Count > 0)
            {
                try
                {
                    int requestId = Convert.ToInt32(dgvRentalRequests.SelectedRows[0].Cells["RequestId"].Value);

                    var rentalRequest = context.RentalRequests.FirstOrDefault(r => r.RequestId == requestId);

                    if (rentalRequest != null)
                    {
                        rentalRequest.RequestStatusId = newStatusId;
                        context.SaveChanges();

                        MessageBox.Show("Request status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshRequestsGridview(); // Refresh the grid
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgvRentalRequests_SelectionChanged(object sender, EventArgs e)
        {


            if (dgvRentalRequests.SelectedRows.Count > 0)
            {


                var fullName = dgvRentalRequests.SelectedRows[0].Cells["FullName"].Value.ToString();
                var equipmentName = dgvRentalRequests.SelectedRows[0].Cells["EquipmentName"].Value.ToString();
                var startDate = Convert.ToDateTime(dgvRentalRequests.SelectedRows[0].Cells["RequestStartDate"].Value);
                var endDate = Convert.ToDateTime(dgvRentalRequests.SelectedRows[0].Cells["RequestEndDate"].Value);

                // Display these values in your right panel (replace with your actual label names)
                lblCustName.Text = fullName;
                lblEqName.Text = equipmentName;
                lblRentPeriod.Text = $"{startDate:MMM dd, yyyy} - {endDate:MMM dd, yyyy}";
                lblPurpose.Text = "Wedding Photography"; // You can replace this with real data if you add a column
            }
        }

        private void HighlightActiveButton(Button activeButton)
        {
            // Put all buttons in a list for easy iteration
            var buttons = new List<Button> {
            dashboardBtn,
            EquipmentBtn,
            rentalRequestsBtn,
            returnsBtn,
            analyticsBtn,
            rentalTransactionsBtn
    };

            Color defaultBackColor = Color.FromArgb(22, 34, 68);
            Color defaultForeColor = Color.FromArgb(233, 239, 255);
            Color defaultBorderColor = Color.FromArgb(41, 58, 107);
            float fontSize = 15.75F;

            // Reset all buttons to default
            foreach (var btn in buttons)
            {
                btn.BackColor = defaultBackColor;
                btn.ForeColor = defaultForeColor;
                btn.FlatAppearance.BorderColor = defaultBorderColor;
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.Font = new Font(btn.Font.FontFamily, fontSize, FontStyle.Bold);

            }

            // Set the active button style
            activeButton.BackColor = Color.FromArgb(28, 44, 91);
            activeButton.ForeColor = Color.White;
            activeButton.FlatAppearance.BorderColor = Color.FromArgb(41, 58, 107);
        }


        private void txtSearchCustOrEq_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatusFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            var DashboardForm = new Dashboard();
            DashboardForm.Show();
            this.Hide();
        }

        private void RentalRequests_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void recentActivitiesTxt_Click(object sender, EventArgs e)
        {

        }

        private void rentalTransactionsBtn_Click(object sender, EventArgs e)
        {
            var RentalTransactionsForm = new RentalTransactions();
            RentalTransactionsForm.Show();
            this.Hide();
        }

        private void RentalRequests_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void returnsBtn_Click_1(object sender, EventArgs e)
        {
            var returnsForm = new Returns();
            returnsForm.Show();
            this.Hide();
        }

        private void EquipmentBtn_Click_1(object sender, EventArgs e)
        {
            var equipmentForm = new EquipmentForm();
            equipmentForm.Show();
            this.Hide();
        }

        private void analyticsBtn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Whoa! This is an exclusive feature for premium members only.\nUpgrade membership to unlock powerful analytics!",
            "Premium Feature",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void btnApprove_Click_1(object sender, EventArgs e)
        {

        }
    }
}
