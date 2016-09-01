using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace lccCtcLinkRolePicker
{
    public partial class lccForm1 : Form
    {
        lccSettingsClass lccSCSettings = new lccSettingsClass();
        public lccForm1(string[] lccParamALArgs)
        {
            InitializeComponent();
            lccCbxLstDescriptions.SelectedIndexChanged += LccCbxLstDescriptions_SelectedIndexChanged;
            lccCbxLstDescriptions.DoubleClick += LccCbxLstDescriptions_DoubleClick;
            lccLbxPillars.SelectedIndexChanged += LccLbxPillars_SelectedIndexChanged;
            lccLbxModules.SelectedIndexChanged += LccLbxModules_SelectedIndexChanged;
            lccLbxNames.SelectedIndexChanged += LccLbxNames_SelectedIndexChanged;
            lccLbxTitles.SelectedIndexChanged += LccLbxTitles_SelectedIndexChanged;
            lccTbxDescriptionsFilter.KeyUp += LccTbxDescriptionsFilter_KeyUp;
        }

        private void LccTbxDescriptionsFilter_KeyUp(object sender, KeyEventArgs e)
        {
            lccTbxDescriptionsFilterApply();
        }
        private void lccTbxDescriptionsFilterApply()
        {
            bool lccBFound = false;
            int lccIDescriptionsListLoop = 0;
            int lccIFiltersFound = 0;
            int lccIFiltersNeeded = 0;
            int lccIDescriptionsFilterLoop = 0;
            string[] lccALDescriptionsFilterSplit = null;
            try
            {
                lccBFound = false;
                lccALDescriptionsFilterSplit = lccTbxDescriptionsFilter.Text.ToLower().Split(' ');
                lccIFiltersNeeded = 0;
                for (lccIDescriptionsFilterLoop = 0; lccIDescriptionsFilterLoop < lccALDescriptionsFilterSplit.Length; lccIDescriptionsFilterLoop++)
                {
                    if (lccALDescriptionsFilterSplit[lccIDescriptionsFilterLoop].Trim().Length > 0)
                    {
                        lccBFound = true;
                        lccIFiltersNeeded++;
                    }
                }
                //lccMenuAbout.Text = lccIFiltersNeeded.ToString();
                if (lccBFound == false)
                {
                    for (lccIDescriptionsListLoop = 0; lccIDescriptionsListLoop < lccSCSettings.lccALDescriptionsList.Count; lccIDescriptionsListLoop++)
                    {
                        lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop].lccBValid = true;
                    }
                }
                else
                {
                    for (lccIDescriptionsListLoop = 0; lccIDescriptionsListLoop < lccSCSettings.lccALDescriptionsList.Count; lccIDescriptionsListLoop++)
                    {
                        lccBFound = false;
                        lccIFiltersFound = 0;
                        for (lccIDescriptionsFilterLoop = 0; lccIDescriptionsFilterLoop < lccALDescriptionsFilterSplit.Length && (lccBFound == false || lccCbxDescriptionsFilterAnd.Checked == true); lccIDescriptionsFilterLoop++)
                        {
                            if (lccALDescriptionsFilterSplit[lccIDescriptionsFilterLoop].Trim().Length > 0)
                            {
                                lccBFound = lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop].lccSValue.Contains(lccALDescriptionsFilterSplit[lccIDescriptionsFilterLoop].Trim());
                                if (lccBFound == true)
                                {
                                    lccIFiltersFound++;
                                }
                            }
                        }
                        if (lccCbxDescriptionsFilterAnd.Checked == false)
                        {
                            lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop].lccBValid = lccBFound;
                        }
                        else
                        {
                            if (lccIFiltersFound == lccIFiltersNeeded)
                            {
                                lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop].lccBValid = true;
                            }
                            else
                            {
                                lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop].lccBValid = false;
                            }
                        }
                    }
                }
                lccFDisplay(2);
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccTbxDescriptionsFilterApply] ERROR: " + lccException.Message);
            }
        }

        private void LccCbxLstDescriptions_DoubleClick(object sender, EventArgs e)
        {
            lccFCbxLstDescriptionsCheck();
        }

        private void LccLbxPillars_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lccSValue = "";
            try
            {
                if (lccLbxPillars.SelectedIndex != -1)
                {
                    lccSValue = lccLbxPillars.Items[lccLbxPillars.SelectedIndex].ToString();
                    if (lccSValue.Length > 7)
                    {
                        if (lccSValue[5] == ']')
                        {
                            lccSValue = lccSValue.Substring(7, lccSValue.Length - 7);
                        }
                    }
                    Clipboard.SetText(lccSValue);
                    lccTbxMessages.Text = lccSValue + "\r\ncopied to clipboard.";
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[LccLbxPillars_SelectedIndexChanged] ERROR: " + lccException.Message);
            }
        }
        private void LccLbxModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lccSValue = "";
            try
            {
                if (lccLbxModules.SelectedIndex != -1)
                {
                    lccSValue = lccLbxModules.Items[lccLbxModules.SelectedIndex].ToString();
                    if (lccSValue.Length > 7)
                    {
                        if (lccSValue[5] == ']')
                        {
                            lccSValue = lccSValue.Substring(7, lccSValue.Length - 7);
                        }
                    }
                    Clipboard.SetText(lccSValue);
                    lccTbxMessages.Text = lccSValue + "\r\ncopied to clipboard.";
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[LccLbxModules_SelectedIndexChanged] ERROR: " + lccException.Message);
            }
        }
        private void LccLbxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lccSValue = "";
            try
            {
                if (lccLbxNames.SelectedIndex != -1)
                {
                    lccSValue = lccLbxNames.Items[lccLbxNames.SelectedIndex].ToString();
                    if (lccSValue.Length > 7)
                    {
                        if (lccSValue[5] == ']')
                        {
                            lccSValue = lccSValue.Substring(7, lccSValue.Length - 7);
                        }
                    }
                    Clipboard.SetText(lccSValue);
                    lccTbxMessages.Text = lccSValue + "\r\ncopied to clipboard.";
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[LccLbxNames_SelectedIndexChanged] ERROR: " + lccException.Message);
            }
        }
        private void LccLbxTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lccSValue = "";
            try
            {
                if (lccLbxTitles.SelectedIndex != -1)
                {
                    lccSValue = lccLbxTitles.Items[lccLbxTitles.SelectedIndex].ToString();
                    if (lccSValue.Length > 7)
                    {
                        if (lccSValue[5] == ']')
                        {
                            lccSValue = lccSValue.Substring(7, lccSValue.Length - 7);
                        }
                    }
                    Clipboard.SetText(lccSValue);
                    lccTbxMessages.Text = lccSValue + "\r\ncopied to clipboard.";
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[LccLbxTitles_SelectedIndexChanged] ERROR: " + lccException.Message);
            }
        }


        private void LccCbxLstDescriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lccFCbxLstDescriptionsCheck();
        }
        private void lccFCbxLstDescriptionsCheck()
        {
            bool lccBPreviousSelectedDescriptionsMismatch = false;
            int lccIItemsLoop = 0;
            int lccIPillarsListLoop = 0;
            int lccIModulesListLoop = 0;
            int lccINamesListLoop = 0;
            int lccITitlesListLoop = 0;
            int lccIDescriptionsSelectedLoop = 0;
            int lccIDescriptionsPreviouslySelectedLoop = 0;

            List<string> lccALDescriptionsSelected = new List<string>();

            try
            {
                lccSCSettings.lccIDescriptionsSelected++;

                //lccMenuAbout.Text = lccSCSettings.lccIDescriptionsSelected.ToString()+":"+lccCbxLstDescriptions.SelectedIndex.ToString();
                if (lccCbxLstDescriptions.SelectedIndex != -1)
                {
                    for (lccIDescriptionsSelectedLoop = 0; lccIDescriptionsSelectedLoop < lccCbxLstDescriptions.CheckedItems.Count; lccIDescriptionsSelectedLoop++)
                    {
                        lccALDescriptionsSelected.Add(lccCbxLstDescriptions.CheckedItems[lccIDescriptionsSelectedLoop].ToString());
                    }
                    if (lccCbxLstDescriptions.CheckedItems.Count != lccSCSettings.lccALPreviousDescriptionsSelected.Count)
                    {
                        lccBPreviousSelectedDescriptionsMismatch = true;
                    }
                    else
                    {
                        for (lccIDescriptionsSelectedLoop = 0; lccIDescriptionsSelectedLoop < lccALDescriptionsSelected.Count && lccBPreviousSelectedDescriptionsMismatch == false; lccIDescriptionsSelectedLoop++)
                        {
                            for (lccIDescriptionsPreviouslySelectedLoop = 0; lccIDescriptionsPreviouslySelectedLoop < lccSCSettings.lccALPreviousDescriptionsSelected.Count && lccBPreviousSelectedDescriptionsMismatch == false; lccIDescriptionsPreviouslySelectedLoop++)
                            {
                                lccBPreviousSelectedDescriptionsMismatch = !lccALDescriptionsSelected[lccIDescriptionsSelectedLoop].Equals(lccSCSettings.lccALPreviousDescriptionsSelected[lccIDescriptionsPreviouslySelectedLoop]);
                            }
                        }
                    }
                    lccSCSettings.lccALPreviousDescriptionsSelected.Clear();
                    for (lccIDescriptionsSelectedLoop = 0; lccIDescriptionsSelectedLoop < lccALDescriptionsSelected.Count; lccIDescriptionsSelectedLoop++)
                    {
                        lccSCSettings.lccALPreviousDescriptionsSelected.Add(lccALDescriptionsSelected[lccIDescriptionsSelectedLoop]);
                    }
                    if (lccBPreviousSelectedDescriptionsMismatch == true)
                    {
                        for (lccIPillarsListLoop = 0; lccIPillarsListLoop < lccSCSettings.lccALPillarsList.Count; lccIPillarsListLoop++)
                        {
                            if (lccALDescriptionsSelected.Count == 0)
                            {
                                lccSCSettings.lccALPillarsList[lccIPillarsListLoop].lccBValid = true;
                            }
                            else
                            {
                                lccSCSettings.lccALPillarsList[lccIPillarsListLoop].lccBValid = lccFCheckCDescriptionConnection(lccALDescriptionsSelected, lccSCSettings.lccALPillarsList[lccIPillarsListLoop].lccALDescriptions);
                            }
                        }
                        for (lccIModulesListLoop = 0; lccIModulesListLoop < lccSCSettings.lccALModulesList.Count; lccIModulesListLoop++)
                        {
                            if (lccALDescriptionsSelected.Count == 0)
                            {
                                lccSCSettings.lccALModulesList[lccIModulesListLoop].lccBValid = true;
                            }
                            else
                            {
                                lccSCSettings.lccALModulesList[lccIModulesListLoop].lccBValid = lccFCheckCDescriptionConnection(lccALDescriptionsSelected, lccSCSettings.lccALModulesList[lccIModulesListLoop].lccALDescriptions);
                            }
                        }
                        for (lccINamesListLoop = 0; lccINamesListLoop < lccSCSettings.lccALNamesList.Count; lccINamesListLoop++)
                        {
                            if (lccALDescriptionsSelected.Count == 0)
                            {
                                lccSCSettings.lccALNamesList[lccINamesListLoop].lccBValid = true;
                            }
                            else
                            {
                                lccSCSettings.lccALNamesList[lccINamesListLoop].lccBValid = lccFCheckCDescriptionConnection(lccALDescriptionsSelected, lccSCSettings.lccALNamesList[lccINamesListLoop].lccALDescriptions);
                            }
                        }
                        for (lccITitlesListLoop = 0; lccITitlesListLoop < lccSCSettings.lccALTitlesList.Count; lccITitlesListLoop++)
                        {
                            if (lccALDescriptionsSelected.Count == 0)
                            {
                                lccSCSettings.lccALTitlesList[lccITitlesListLoop].lccBValid = true;
                            }
                            else
                            {
                                lccSCSettings.lccALTitlesList[lccITitlesListLoop].lccBValid = lccFCheckCDescriptionConnection(lccALDescriptionsSelected, lccSCSettings.lccALTitlesList[lccITitlesListLoop].lccALDescriptions);
                            }
                        }
                        lccFDisplay(1);
                    }
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[LccCbxLstDescriptions_SelectedIndexChanged] ERROR: " + lccException.Message);
            }


        }
        private bool lccFCheckCDescriptionConnection(List<string> lccParamALSelectedDescriptions, List<string> lccParamALListDescriptions)
        {
            bool lccBReturn = false;
            bool lccBFound = false;
            int lccISelectedDescriptionsLoop = 0;
            int lccIListDescriptionsLoop = 0;
            int lccIMatched = 0;
            try
            {
                for (lccISelectedDescriptionsLoop=0; lccISelectedDescriptionsLoop< lccParamALSelectedDescriptions.Count; lccISelectedDescriptionsLoop++)
                {
                    lccBFound = false;
                    for (lccIListDescriptionsLoop = 0; lccIListDescriptionsLoop < lccParamALListDescriptions.Count && lccBFound == false; lccIListDescriptionsLoop++)
                    {
                        lccBFound = lccParamALSelectedDescriptions[lccISelectedDescriptionsLoop].Equals(lccParamALListDescriptions[lccIListDescriptionsLoop]);
                    }
                    if (lccBFound == true)
                    {
                        lccIMatched++;
                    }
                }
                if (lccIMatched == lccParamALSelectedDescriptions.Count)
                {
                    lccBReturn = true;
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFCheckCDescriptionConnection] ERROR: " + lccException.Message);
            }
            return lccBReturn;
        }
        private void lccMenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("lccCtcLinkRolePicker: Filter/Pick ctcLink/PS Roles depending on requirements.\r\n\r\ncreated by: David Mielcarek, Lower Columbia College\r\n\r\n");
        }

        private lccListClass lccFReturnNewList(lccListClass lccParamList)
        {
            int lccIDescriptionsLoop = 0;
            lccListClass lccReturn = new lccListClass();
            lccReturn.lccBValid = lccParamList.lccBValid;
            lccReturn.lccSValue = lccParamList.lccSValue;
            for (lccIDescriptionsLoop=0; lccIDescriptionsLoop<lccParamList.lccALDescriptions.Count; lccIDescriptionsLoop++)
            {
                lccReturn.lccALDescriptions.Add(lccParamList.lccALDescriptions[lccIDescriptionsLoop]);
            }
            return lccReturn;
        }
        private lccRecordClass lccFReturnNewRecord(lccRecordClass lccParamRecord)
        {
            int lccIDescriptionsLoop = 0;
            string[] lccALDescriptionsSplit = null;
            lccRecordClass lccReturn = new lccRecordClass();
            lccReturn.lccSPillar = lccParamRecord.lccSPillar;
            lccReturn.lccSModule = lccParamRecord.lccSModule;
            lccReturn.lccSName = lccParamRecord.lccSName;
            lccReturn.lccSTitle = lccParamRecord.lccSTitle;
            lccReturn.lccSDescription = lccParamRecord.lccSDescription.Replace(".",",").Replace(":",",").Replace("&",",").Replace("(", ",").Replace(")", ",").Replace("/", ",");
            lccALDescriptionsSplit = lccReturn.lccSDescription.Split(',');
            for (lccIDescriptionsLoop=0; lccIDescriptionsLoop< lccALDescriptionsSplit.Length; lccIDescriptionsLoop++)
            {
                lccReturn.lccALDescriptions.Add(lccALDescriptionsSplit[lccIDescriptionsLoop].Trim());
            }
            return lccReturn;
        }
        private void lccBtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                lccFLoad();
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccBtnLoad_Click] ERROR: " + lccException.Message);
            }

        }
        private bool lccFLoad()
        {
            bool lccBReturn = false;
            bool lccBAbortFunction = false;
            int lccIDescriptionsLoop = 0;
            int lccILinesLoop = 0;
            string lccSSource = "";
            string[] lccALSourceSplit = null;
            string[] lccALDescriptionsSplit = null;
            string[] lccALPathSplit = null;
            string[] lccALDownloadSplit = null;
            StringBuilder lccSBSource = new StringBuilder();
            FileStream lccFSSource = null;
            StreamReader lccSRSource = null;
            lccRecordClass lccRecord = new lccRecordClass();
            WebClient lccWebClient = null;
            StringBuilder lccSBDownload = new StringBuilder();

            try
            {
                lccSCSettings.lccALPillarsList.Clear();
                lccSCSettings.lccALModulesList.Clear();
                lccSCSettings.lccALNamesList.Clear();
                lccSCSettings.lccALTitlesList.Clear();
                lccSCSettings.lccALDescriptionsList.Clear();

                lccSCSettings.lccALRecords.Clear();
                lccSCSettings.lccALPreviousDescriptionsSelected.Clear();

                lccTbxMessages.Text = "";
                lccTbxDescriptionsFilter.Text = "";

                lccALPathSplit = lccTbxSourcePath.Text.ToLower().Split(':');
                if (lccALPathSplit[0].Equals("http") == true
                    || lccALPathSplit[0].Equals("https") == true
                    )
                {
                    lccWebClient = new WebClient();
                    try
                    {
                        lccTbxMessages.Text += "\r\nDownload web data...please wait";
                        lccTbxMessages.Refresh();
                        lccSBDownload.Append(lccWebClient.DownloadString(lccTbxSourcePath.Text).Replace("\r", ""));
                    }
                    catch (Exception lccDownloadException)
                    {
                        MessageBox.Show("There was an issue downloading the Settings from the URL provided.\r\n\r\nERROR: " + lccDownloadException.Message);
                        lccBAbortFunction = true;
                    }
                }
                else
                {
                    if (File.Exists(lccTbxSourcePath.Text) == false)
                    {
                        MessageBox.Show("Path/file not found.");
                        lccBAbortFunction = true;
                    }
                }

                if (lccBAbortFunction == false)
                    {
                    if (lccSBDownload.Length > 0)
                    {
                        lccTbxMessages.Text += "\r\nLoading web data...please wait";
                        lccTbxMessages.Refresh();
                        lccALDownloadSplit = lccSBDownload.ToString().Split('\n');
                        for (lccILinesLoop=0; lccILinesLoop<lccALDownloadSplit.Length; lccILinesLoop++)
                        {
                            if (lccALDownloadSplit[lccILinesLoop].Length > 0)
                            {
                                lccALSourceSplit = lccALDownloadSplit[lccILinesLoop].Split('\t');
                                if (lccALSourceSplit.Length == 5)
                                {
                                    lccRecord.lccFClearValues();
                                    lccRecord.lccSPillar = lccALSourceSplit[0];
                                    lccRecord.lccSModule = lccALSourceSplit[1];
                                    lccRecord.lccSName = lccALSourceSplit[2];
                                    lccRecord.lccSTitle = lccALSourceSplit[3];
                                    lccRecord.lccSDescription = lccALSourceSplit[4].ToLower().Replace(".", ",");

                                    lccALDescriptionsSplit = lccRecord.lccSDescription.Split(',');
                                    for (lccIDescriptionsLoop = 0; lccIDescriptionsLoop < lccALDescriptionsSplit.Length; lccIDescriptionsLoop++)
                                    {
                                        lccRecord.lccALDescriptions.Add(lccALDescriptionsSplit[lccIDescriptionsLoop].Trim());
                                    }

                                    lccSCSettings.lccALRecords.Add(lccFReturnNewRecord(lccRecord));
                                }
                            }
                        }
                    }
                    else
                    {
                        lccFSSource = new FileStream(lccTbxSourcePath.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
                        lccSRSource = new StreamReader(lccFSSource);

                        lccTbxMessages.Text += "\r\nLoading local data...please wait";
                        lccTbxMessages.Refresh();
                        do
                        {
                            lccSSource = lccSRSource.ReadLine();
                            if (lccSSource != null)
                            {
                                if (lccSSource.Length > 0)
                                {
                                    lccALSourceSplit = lccSSource.Split('\t');
                                    if (lccALSourceSplit.Length == 5)
                                    {
                                        lccRecord.lccFClearValues();
                                        lccRecord.lccSPillar = lccALSourceSplit[0];
                                        lccRecord.lccSModule = lccALSourceSplit[1];
                                        lccRecord.lccSName = lccALSourceSplit[2];
                                        lccRecord.lccSTitle = lccALSourceSplit[3];
                                        lccRecord.lccSDescription = lccALSourceSplit[4].ToLower().Replace(".", ",");

                                        lccALDescriptionsSplit = lccRecord.lccSDescription.Split(',');
                                        for (lccIDescriptionsLoop = 0; lccIDescriptionsLoop < lccALDescriptionsSplit.Length; lccIDescriptionsLoop++)
                                        {
                                            lccRecord.lccALDescriptions.Add(lccALDescriptionsSplit[lccIDescriptionsLoop].Trim());
                                        }

                                        lccSCSettings.lccALRecords.Add(lccFReturnNewRecord(lccRecord));
                                    }
                                }
                            }

                        } while (lccSSource != null);
                        lccSRSource.Close();
                        lccFSSource.Close();
                    }
                    lccFPopulate();
                    lccBReturn = true;
                }
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFLoad] ERROR: " + lccException.Message);
            }
            return lccBReturn;
        }
        private bool lccFPopulate()
        {
            bool lccBReturn = false;
            bool lccBFound = false;
            int lccIRecordsLoop = 0;
            int lccIPillarsListLoop = 0;
            int lccIModulesListLoop = 0;
            int lccINamesListLoop = 0;
            int lccITitlesListLoop = 0;
            int lccIDescriptionsListLoop = 0;
            int lccIDescriptionsLoop = 0;
            int lccIListDescriptionsLoop = 0;

            StringBuilder lccSBOutput = new StringBuilder();

            lccListClass lccList = new lccListClass();
            try
            {

                for (lccIRecordsLoop = 0; lccIRecordsLoop < lccSCSettings.lccALRecords.Count; lccIRecordsLoop++)
                {
                        lccBFound = false;
                    for (lccIPillarsListLoop=0; lccIPillarsListLoop< lccSCSettings.lccALPillarsList.Count && lccBFound==false; lccIPillarsListLoop++)
                    {
                        lccBFound = lccSCSettings.lccALPillarsList[lccIPillarsListLoop].lccSValue.Equals(lccSCSettings.lccALRecords[lccIRecordsLoop].lccSPillar);
                    }
                    if (lccBFound == false)
                    {
                        lccList.lccFClearValues();
                        lccList.lccBValid = true;
                        lccList.lccSValue = lccSCSettings.lccALRecords[lccIRecordsLoop].lccSPillar;
                        lccSCSettings.lccALPillarsList.Add(lccFReturnNewList(lccList));
                    }

                    lccBFound = false;
                    for (lccIModulesListLoop = 0; lccIModulesListLoop < lccSCSettings.lccALModulesList.Count && lccBFound == false; lccIModulesListLoop++)
                    {
                        lccBFound = lccSCSettings.lccALModulesList[lccIModulesListLoop].lccSValue.Equals(lccSCSettings.lccALRecords[lccIRecordsLoop].lccSModule);
                    }
                    if (lccBFound == false)
                    {
                        lccList.lccFClearValues();
                        lccList.lccBValid = true;
                        lccList.lccSValue = lccSCSettings.lccALRecords[lccIRecordsLoop].lccSModule;
                        lccSCSettings.lccALModulesList.Add(lccFReturnNewList(lccList));
                    }

                    lccBFound = false;
                    for (lccINamesListLoop = 0; lccINamesListLoop < lccSCSettings.lccALNamesList.Count && lccBFound == false; lccINamesListLoop++)
                    {
                        lccBFound = lccSCSettings.lccALNamesList[lccINamesListLoop].lccSValue.Equals(lccSCSettings.lccALRecords[lccIRecordsLoop].lccSName);
                    }
                    if (lccBFound == false)
                    {
                        lccList.lccFClearValues();
                        lccList.lccBValid = true;
                        lccList.lccSValue = lccSCSettings.lccALRecords[lccIRecordsLoop].lccSName;
                        lccSCSettings.lccALNamesList.Add(lccFReturnNewList(lccList));
                    }

                    lccBFound = false;
                    for (lccITitlesListLoop = 0; lccITitlesListLoop < lccSCSettings.lccALTitlesList.Count && lccBFound == false; lccITitlesListLoop++)
                    {
                        lccBFound = lccSCSettings.lccALTitlesList[lccITitlesListLoop].lccSValue.Equals(lccSCSettings.lccALRecords[lccIRecordsLoop].lccSTitle);
                    }
                    if (lccBFound == false)
                    {
                        lccList.lccFClearValues();
                        lccList.lccBValid = true;
                        lccList.lccSValue = lccSCSettings.lccALRecords[lccIRecordsLoop].lccSTitle;
                        lccSCSettings.lccALTitlesList.Add(lccFReturnNewList(lccList));
                    }

                    for (lccIDescriptionsLoop=0; lccIDescriptionsLoop< lccSCSettings.lccALRecords[lccIRecordsLoop].lccALDescriptions.Count; lccIDescriptionsLoop++)
                    {
                        if (lccSCSettings.lccALRecords[lccIRecordsLoop].lccALDescriptions[lccIDescriptionsLoop].Length > 0)
                        {
                            lccBFound = false;
                            for (lccIDescriptionsListLoop = 0; lccIDescriptionsListLoop < lccSCSettings.lccALDescriptionsList.Count && lccBFound == false; lccIDescriptionsListLoop++)
                            {
                                lccBFound = lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop].lccSValue.Equals(lccSCSettings.lccALRecords[lccIRecordsLoop].lccALDescriptions[lccIDescriptionsLoop].Trim());
                            }
                            if (lccBFound == false)
                            {
                                lccList.lccFClearValues();
                                lccList.lccBValid = true;
                                lccList.lccSValue = lccSCSettings.lccALRecords[lccIRecordsLoop].lccALDescriptions[lccIDescriptionsLoop].Trim();
                                lccSCSettings.lccALDescriptionsList.Add(lccFReturnNewList(lccList));
                            }
                        }
                    }
                }
                //MessageBox.Show("t0");
                for (lccIRecordsLoop = 0; lccIRecordsLoop < lccSCSettings.lccALRecords.Count; lccIRecordsLoop++)
                {
                    //MessageBox.Show("t1");
                    for (lccIDescriptionsLoop = 0; lccIDescriptionsLoop < lccSCSettings.lccALRecords[lccIRecordsLoop].lccALDescriptions.Count; lccIDescriptionsLoop++)
                    {
                        //MessageBox.Show("t2");
                        lccFBuildDescriptionConnection(1, lccSCSettings.lccALRecords[lccIRecordsLoop].lccSPillar, lccSCSettings.lccALRecords[lccIRecordsLoop].lccALDescriptions[lccIDescriptionsLoop]);
                        lccFBuildDescriptionConnection(2, lccSCSettings.lccALRecords[lccIRecordsLoop].lccSModule, lccSCSettings.lccALRecords[lccIRecordsLoop].lccALDescriptions[lccIDescriptionsLoop]);
                        lccFBuildDescriptionConnection(3, lccSCSettings.lccALRecords[lccIRecordsLoop].lccSName, lccSCSettings.lccALRecords[lccIRecordsLoop].lccALDescriptions[lccIDescriptionsLoop]);
                        lccFBuildDescriptionConnection(4, lccSCSettings.lccALRecords[lccIRecordsLoop].lccSTitle, lccSCSettings.lccALRecords[lccIRecordsLoop].lccALDescriptions[lccIDescriptionsLoop]);

                    }
                }
                //MessageBox.Show("s1: "+lccSCSettings.lccALPillarsList.Count.ToString()+":"+ lccSCSettings.lccALDescriptionsList.Count.ToString());

                lccFSort();
                lccBReturn = true;
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFPopulate] ERROR: " + lccException.Message);
            }
            return lccBReturn;
        }
        private bool lccFBuildDescriptionConnection(int lccParamIFlag, string lccParamSCategory, string lccParamSValue)
        {
            // lccParamIFlag
            // 1 - Pillars
            // 2 - Modules
            // 3 - Names
            // 4 - Titles
            bool lccBReturn = false;
            bool lccBFound = false;
            int lccIListLoop = 0;
            int lccIListDescriptionsLoop = 0;
            try
            {

                switch (lccParamIFlag)
                {
                    case 1:
                        for (lccIListLoop = 0; lccIListLoop < lccSCSettings.lccALPillarsList.Count; lccIListLoop++)
                        {
                            //MessageBox.Show("s1: " + lccSCSettings.lccALPillarsList[lccIPillarsListLoop].lccSValue + ":" + lccParamSCategory);
                            if (lccSCSettings.lccALPillarsList[lccIListLoop].lccSValue.Equals(lccParamSCategory) == true)
                            {
                                lccBFound = false;
                                //MessageBox.Show("s2: " + lccParamSValue);
                                for (lccIListDescriptionsLoop = 0; lccIListDescriptionsLoop < lccSCSettings.lccALPillarsList[lccIListLoop].lccALDescriptions.Count && lccBFound == false; lccIListDescriptionsLoop++)
                                {
                                    lccBFound = lccSCSettings.lccALPillarsList[lccIListLoop].lccALDescriptions[lccIListDescriptionsLoop].Equals(lccParamSValue);
                                    //MessageBox.Show("s3: " + lccBFound.ToString() + ":" + lccSCSettings.lccALPillarsList[lccIPillarsListLoop].lccALDescriptions[lccIListDescriptionsLoop] + ":" + lccParamSValue);
                                }
                                if (lccBFound == false)
                                {
                                    //MessageBox.Show("s5: " + lccParamSValue);
                                    lccSCSettings.lccALPillarsList[lccIListLoop].lccALDescriptions.Add(lccParamSValue);
                                }
                            }
                        }
                        break;
                    case 2:
                        for (lccIListLoop = 0; lccIListLoop < lccSCSettings.lccALModulesList.Count; lccIListLoop++)
                        {
                            //MessageBox.Show("s1: " + lccSCSettings.lccALModulesList[lccIModulesListLoop].lccSValue + ":" + lccParamSCategory);
                            if (lccSCSettings.lccALModulesList[lccIListLoop].lccSValue.Equals(lccParamSCategory) == true)
                            {
                                lccBFound = false;
                                //MessageBox.Show("s2: " + lccParamSValue);
                                for (lccIListDescriptionsLoop = 0; lccIListDescriptionsLoop < lccSCSettings.lccALModulesList[lccIListLoop].lccALDescriptions.Count && lccBFound == false; lccIListDescriptionsLoop++)
                                {
                                    lccBFound = lccSCSettings.lccALModulesList[lccIListLoop].lccALDescriptions[lccIListDescriptionsLoop].Equals(lccParamSValue);
                                    //MessageBox.Show("s3: " + lccBFound.ToString() + ":" + lccSCSettings.lccALModulesList[lccIModulesListLoop].lccALDescriptions[lccIListDescriptionsLoop] + ":" + lccParamSValue);
                                }
                                if (lccBFound == false)
                                {
                                    //MessageBox.Show("s5: " + lccParamSValue);
                                    lccSCSettings.lccALModulesList[lccIListLoop].lccALDescriptions.Add(lccParamSValue);
                                }
                            }
                        }
                        break;
                    case 3:
                        for (lccIListLoop = 0; lccIListLoop < lccSCSettings.lccALNamesList.Count; lccIListLoop++)
                        {
                            //MessageBox.Show("s1: " + lccSCSettings.lccALNamesList[lccINamesListLoop].lccSValue + ":" + lccParamSCategory);
                            if (lccSCSettings.lccALNamesList[lccIListLoop].lccSValue.Equals(lccParamSCategory) == true)
                            {
                                lccBFound = false;
                                //MessageBox.Show("s2: " + lccParamSValue);
                                for (lccIListDescriptionsLoop = 0; lccIListDescriptionsLoop < lccSCSettings.lccALNamesList[lccIListLoop].lccALDescriptions.Count && lccBFound == false; lccIListDescriptionsLoop++)
                                {
                                    lccBFound = lccSCSettings.lccALNamesList[lccIListLoop].lccALDescriptions[lccIListDescriptionsLoop].Equals(lccParamSValue);
                                    //MessageBox.Show("s3: " + lccBFound.ToString() + ":" + lccSCSettings.lccALNamesList[lccINamesListLoop].lccALDescriptions[lccIListDescriptionsLoop] + ":" + lccParamSValue);
                                }
                                if (lccBFound == false)
                                {
                                    //MessageBox.Show("s5: " + lccParamSValue);
                                    lccSCSettings.lccALNamesList[lccIListLoop].lccALDescriptions.Add(lccParamSValue);
                                }
                            }
                        }
                        break;
                    case 4:
                        for (lccIListLoop = 0; lccIListLoop < lccSCSettings.lccALTitlesList.Count; lccIListLoop++)
                        {
                            //MessageBox.Show("s1: " + lccSCSettings.lccALTitlesList[lccITitlesListLoop].lccSValue + ":" + lccParamSCategory);
                            if (lccSCSettings.lccALTitlesList[lccIListLoop].lccSValue.Equals(lccParamSCategory) == true)
                            {
                                lccBFound = false;
                                //MessageBox.Show("s2: " + lccParamSValue);
                                for (lccIListDescriptionsLoop = 0; lccIListDescriptionsLoop < lccSCSettings.lccALTitlesList[lccIListLoop].lccALDescriptions.Count && lccBFound == false; lccIListDescriptionsLoop++)
                                {
                                    lccBFound = lccSCSettings.lccALTitlesList[lccIListLoop].lccALDescriptions[lccIListDescriptionsLoop].Equals(lccParamSValue);
                                    //MessageBox.Show("s3: " + lccBFound.ToString() + ":" + lccSCSettings.lccALTitlesList[lccITitlesListLoop].lccALDescriptions[lccIListDescriptionsLoop] + ":" + lccParamSValue);
                                }
                                if (lccBFound == false)
                                {
                                    //MessageBox.Show("s5: " + lccParamSValue);
                                    lccSCSettings.lccALTitlesList[lccIListLoop].lccALDescriptions.Add(lccParamSValue);
                                }
                            }
                        }
                        break;
                }
                lccBReturn = true;
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFBuildDescriptionConnection] ERROR: " + lccException.Message);
            }
            return lccBReturn;
        }

        private bool lccFSort()
        {
            bool lccBReturn = false;
            bool lccBFound = false;
            int lccIPillarsListLoop = 0;
            int lccIModulesListLoop = 0;
            int lccINamesListLoop = 0;
            int lccITitlesListLoop = 0;
            int lccIDescriptionsListLoop = 0;
            lccListClass lccList = new lccListClass();
            string lccSHold = "";
            try
            {
                do
                {
                    lccBFound = false;
                    for (lccIPillarsListLoop = 0; lccIPillarsListLoop < lccSCSettings.lccALPillarsList.Count - 1; lccIPillarsListLoop++)
                    {
                        if (lccSCSettings.lccALPillarsList[lccIPillarsListLoop].lccSValue.CompareTo(lccSCSettings.lccALPillarsList[lccIPillarsListLoop + 1].lccSValue) > 0)
                        {
                            lccBFound = true;
                            lccList = lccFReturnNewList(lccSCSettings.lccALPillarsList[lccIPillarsListLoop]);
                            lccSCSettings.lccALPillarsList[lccIPillarsListLoop] = lccFReturnNewList(lccSCSettings.lccALPillarsList[lccIPillarsListLoop + 1]);
                            lccSCSettings.lccALPillarsList[lccIPillarsListLoop + 1] = lccFReturnNewList(lccList);
                        }
                    }
                } while (lccBFound == true);

                do
                {
                    lccBFound = false;
                    for (lccIModulesListLoop = 0; lccIModulesListLoop < lccSCSettings.lccALModulesList.Count - 1; lccIModulesListLoop++)
                    {
                        if (lccSCSettings.lccALModulesList[lccIModulesListLoop].lccSValue.CompareTo(lccSCSettings.lccALModulesList[lccIModulesListLoop + 1].lccSValue) > 0)
                        {
                            lccBFound = true;
                            lccList = lccFReturnNewList(lccSCSettings.lccALModulesList[lccIModulesListLoop]);
                            lccSCSettings.lccALModulesList[lccIModulesListLoop] = lccFReturnNewList(lccSCSettings.lccALModulesList[lccIModulesListLoop + 1]);
                            lccSCSettings.lccALModulesList[lccIModulesListLoop + 1] = lccFReturnNewList(lccList);
                        }
                    }
                } while (lccBFound == true);

                do
                {
                    lccBFound = false;
                    for (lccINamesListLoop = 0; lccINamesListLoop < lccSCSettings.lccALNamesList.Count - 1; lccINamesListLoop++)
                    {
                        if (lccSCSettings.lccALNamesList[lccINamesListLoop].lccSValue.CompareTo(lccSCSettings.lccALNamesList[lccINamesListLoop + 1].lccSValue) > 0)
                        {
                            lccBFound = true;
                            lccList = lccFReturnNewList(lccSCSettings.lccALNamesList[lccINamesListLoop]);
                            lccSCSettings.lccALNamesList[lccINamesListLoop] = lccFReturnNewList(lccSCSettings.lccALNamesList[lccINamesListLoop + 1]);
                            lccSCSettings.lccALNamesList[lccINamesListLoop + 1] = lccFReturnNewList(lccList);
                        }
                    }
                } while (lccBFound == true);

                do
                {
                    lccBFound = false;
                    for (lccITitlesListLoop = 0; lccITitlesListLoop < lccSCSettings.lccALTitlesList.Count - 1; lccITitlesListLoop++)
                    {
                        if (lccSCSettings.lccALTitlesList[lccITitlesListLoop].lccSValue.CompareTo(lccSCSettings.lccALTitlesList[lccITitlesListLoop + 1].lccSValue) > 0)
                        {
                            lccBFound = true;
                            lccList = lccFReturnNewList(lccSCSettings.lccALTitlesList[lccITitlesListLoop]);
                            lccSCSettings.lccALTitlesList[lccITitlesListLoop] = lccFReturnNewList(lccSCSettings.lccALTitlesList[lccITitlesListLoop + 1]);
                            lccSCSettings.lccALTitlesList[lccITitlesListLoop + 1] = lccFReturnNewList(lccList);
                        }
                    }
                } while (lccBFound == true);

                do
                {
                    lccBFound = false;
                    for (lccIDescriptionsListLoop = 0; lccIDescriptionsListLoop < lccSCSettings.lccALDescriptionsList.Count - 1; lccIDescriptionsListLoop++)
                    {
                        if (lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop].lccSValue.CompareTo(lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop + 1].lccSValue) > 0)
                        {
                            lccBFound = true;
                            lccList = lccFReturnNewList(lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop]);
                            lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop] = lccFReturnNewList(lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop + 1]);
                            lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop + 1] = lccFReturnNewList(lccList);
                        }
                    }
                } while (lccBFound == true);

                lccFDisplay(0);
                lccBReturn = true;
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFPopulate] ERROR: " + lccException.Message);
            }
            return lccBReturn;
        }
        private string lccFReturnFixedLength(int lccParamILength, string lccParamSValue)
        {
            int lccILoop = 0;
            StringBuilder lccSBOutput = new StringBuilder();
            try
            {
                if (lccParamSValue.Length < lccParamILength)
                {
                    for (lccILoop = 0; lccILoop < lccParamILength - lccParamSValue.Length; lccILoop++)
                    {
                        lccSBOutput.Append(" ");
                    }
                }
                lccSBOutput.Append(lccParamSValue);
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFReturnFixedLength] ERROR: " + lccException.Message);
            }
            return lccSBOutput.ToString();
        }
        private bool lccFDisplay(int lccParamIFlag)
        {
            // lccParamIFlag
            // 0 - show all
            // 1 - no descriptions
            // 2 - only descriptions
            bool lccBReturn = false;
            bool lccBFound = false;
            int lccIPillarsListLoop = 0;
            int lccIModulesListLoop = 0;
            int lccINamesListLoop = 0;
            int lccITitlesListLoop = 0;
            int lccIDescriptionsListLoop = 0;
            int lccIDescriptionsLoop = 0;
            StringBuilder lccSBOutput = new StringBuilder();
            try
            {
                lccTbxMessages.Text = "";
                if (lccParamIFlag == 0
                    || lccParamIFlag == 1)
                {
                    lccLbxPillars.Items.Clear();
                    lccLbxModules.Items.Clear();
                    lccLbxNames.Items.Clear();
                    lccLbxTitles.Items.Clear();
                }
                if (lccParamIFlag == 0
                    || lccParamIFlag == 2)
                {
                    lccCbxLstDescriptions.Items.Clear();
                }
                if (lccParamIFlag == 0
                    || lccParamIFlag == 1
                    )
                {
                    do
                    {
                        lccBFound = false;
                        for (lccIPillarsListLoop = 0; lccIPillarsListLoop < lccSCSettings.lccALPillarsList.Count; lccIPillarsListLoop++)
                        {
                            if (lccSCSettings.lccALPillarsList[lccIPillarsListLoop].lccBValid == true)
                            {
                                lccLbxPillars.Items.Add("[" + lccFReturnFixedLength(4, lccSCSettings.lccALPillarsList[lccIPillarsListLoop].lccALDescriptions.Count.ToString()) + "] " + lccSCSettings.lccALPillarsList[lccIPillarsListLoop].lccSValue);
                            }
                        }
                    } while (lccBFound == true);

                    do
                    {
                        lccBFound = false;
                        for (lccIModulesListLoop = 0; lccIModulesListLoop < lccSCSettings.lccALModulesList.Count; lccIModulesListLoop++)
                        {
                            if (lccSCSettings.lccALModulesList[lccIModulesListLoop].lccBValid == true)
                            {
                                lccLbxModules.Items.Add("[" + lccFReturnFixedLength(4, lccSCSettings.lccALModulesList[lccIModulesListLoop].lccALDescriptions.Count.ToString()) + "] " + lccSCSettings.lccALModulesList[lccIModulesListLoop].lccSValue);
                            }
                        }
                    } while (lccBFound == true);

                    do
                    {
                        lccBFound = false;
                        for (lccINamesListLoop = 0; lccINamesListLoop < lccSCSettings.lccALNamesList.Count; lccINamesListLoop++)
                        {
                            if (lccSCSettings.lccALNamesList[lccINamesListLoop].lccBValid == true)
                            {
                                lccLbxNames.Items.Add("[" + lccFReturnFixedLength(4, lccSCSettings.lccALNamesList[lccINamesListLoop].lccALDescriptions.Count.ToString()) + "] " + lccSCSettings.lccALNamesList[lccINamesListLoop].lccSValue);
                            }
                        }
                    } while (lccBFound == true);

                    do
                    {
                        lccBFound = false;
                        for (lccITitlesListLoop = 0; lccITitlesListLoop < lccSCSettings.lccALTitlesList.Count; lccITitlesListLoop++)
                        {
                            if (lccSCSettings.lccALTitlesList[lccITitlesListLoop].lccBValid == true)
                            {
                                lccLbxTitles.Items.Add("[" + lccFReturnFixedLength(4, lccSCSettings.lccALTitlesList[lccITitlesListLoop].lccALDescriptions.Count.ToString()) + "] " + lccSCSettings.lccALTitlesList[lccITitlesListLoop].lccSValue);
                            }
                        }
                    } while (lccBFound == true);
                }

                if (lccParamIFlag == 0
                    || lccParamIFlag == 2
                    )
                {
                    do
                    {
                        lccBFound = false;
                        for (lccIDescriptionsListLoop = 0; lccIDescriptionsListLoop < lccSCSettings.lccALDescriptionsList.Count; lccIDescriptionsListLoop++)
                        {
                            if (lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop].lccBValid == true)
                            {
                                lccCbxLstDescriptions.Items.Add(lccSCSettings.lccALDescriptionsList[lccIDescriptionsListLoop].lccSValue);
                            }
                        }
                    } while (lccBFound == true);
                }
                lccTbxMessages.Text += "Unique Descriptions: " + lccCbxLstDescriptions.Items.Count.ToString() + "\r\n";
                lccTbxMessages.Text += "Unique Pillars: " + lccLbxPillars.Items.Count.ToString() + "\r\n";
                lccTbxMessages.Text += "Unique Modules: " + lccLbxModules.Items.Count.ToString() + "\r\n";
                lccTbxMessages.Text += "Unique Titles: " + lccLbxTitles.Items.Count.ToString() + "\r\n";
                lccTbxMessages.Text += "Unique Names: " + lccLbxNames.Items.Count.ToString() + "\r\n";

                /*
                for (lccIPillarsListLoop = 0; lccIPillarsListLoop < lccSCSettings.lccALPillarsList.Count; lccIPillarsListLoop++)
                {
                    for (lccIDescriptionsLoop = 0; lccIDescriptionsLoop < lccSCSettings.lccALPillarsList[lccIPillarsListLoop].lccALDescriptions.Count; lccIDescriptionsLoop++)
                    {
                        lccSBOutput.Append(lccSCSettings.lccALPillarsList[lccIPillarsListLoop].lccSValue+"\t"+ lccSCSettings.lccALPillarsList[lccIPillarsListLoop].lccALDescriptions[lccIDescriptionsLoop]+"\r\n");
                    }
                }
                lccTbxResults.Text += lccSBOutput.ToString();
                for (lccINamesListLoop = 0; lccINamesListLoop < lccSCSettings.lccALNamesList.Count; lccINamesListLoop++)
                {
                    for (lccIDescriptionsLoop = 0; lccIDescriptionsLoop < lccSCSettings.lccALNamesList[lccINamesListLoop].lccALDescriptions.Count; lccIDescriptionsLoop++)
                    {
                        lccSBOutput.Append(lccSCSettings.lccALNamesList[lccINamesListLoop].lccSValue + "\t" + lccSCSettings.lccALNamesList[lccINamesListLoop].lccALDescriptions[lccIDescriptionsLoop] + "\r\n");
                    }
                }
                lccTbxResults.Text += lccSBOutput.ToString();
                */


                lccBReturn = true;
            }
            catch (Exception lccException)
            {
                MessageBox.Show("[lccFPopulate] ERROR: " + lccException.Message);
            }
            return lccBReturn;
        }

        private void lccMenuHelp_Click(object sender, EventArgs e)
        {
            StringBuilder lccSBOutput = new StringBuilder();
            lccSBOutput.Append("STEPS:");
            lccSBOutput.Append("\r\n_______1. Enter Source Path (either local network/folder or web)");
            lccSBOutput.Append("\r\n_______2. Click Load");
            lccSBOutput.Append("\r\n_______3. Check the Descriptions (abilities) you want to filter on");
            lccSBOutput.Append("\r\n\r\nIn the Pillars, Modules, Titles, and Names boxes:");
            lccSBOutput.Append("\r\n_______ The [ #### ] next to each row shows many Descriptions are connected to this value");
            lccSBOutput.Append("\r\n_______ Clicking on a row will copy that value to your clipboard");
            MessageBox.Show(lccSBOutput.ToString());
        }

        private void lccCbxDescriptionsFilterAnd_CheckedChanged(object sender, EventArgs e)
        {
            if (lccCbxDescriptionsFilterAnd.Checked == false)
            {
                lccLblDescriptionsWordFilter.Text =  "DescriptionsWord(s) 'OR' Filter";
            }
            else
            {
                lccLblDescriptionsWordFilter.Text = "DescriptionsWord(s) 'AND' Filter";
            }
            lccTbxDescriptionsFilterApply();
        }
    }
    class lccRecordClass
    {
        public string lccSPillar { get; set; }
        public string lccSModule { get; set; }
        public string lccSName { get; set; }
        public string lccSTitle { get; set; }
        public string lccSDescription { get; set; }
        public List<string> lccALDescriptions = new List<string>();
        public lccRecordClass()
        {
            lccFClearValues();
        }
        public void lccFClearValues()
        {
            lccSPillar = "";
            lccSModule = "";
            lccSName = "";
            lccSTitle = "";
            lccSDescription = "";
            lccALDescriptions.Clear();
        }
    }
    class lccListClass
    {
        public bool lccBValid { get; set; }
        public string lccSValue { get; set; }
        public List<string> lccALDescriptions = new List<string>();
        public lccListClass()
        {
            lccFClearValues();
        }
        public void lccFClearValues()
        {
            lccBValid = false;
            lccSValue = "";
            lccALDescriptions.Clear();
        }
    }
    class lccSettingsClass
    {
        public int lccIDescriptionsSelected { get; set; }
        public List<lccRecordClass> lccALRecords = new List<lccRecordClass>();
        public List<lccListClass> lccALPillarsList = new List<lccListClass>();
        public List<lccListClass> lccALModulesList = new List<lccListClass>();
        public List<lccListClass> lccALNamesList = new List<lccListClass>();
        public List<lccListClass> lccALTitlesList = new List<lccListClass>();
        public List<lccListClass> lccALDescriptionsList = new List<lccListClass>();
        public List<string> lccALPreviousDescriptionsSelected = new List<string>();
        public lccSettingsClass()
        {
            lccFClearValues();
        }
        public void lccFClearValues()
        {
            lccIDescriptionsSelected = 0;
            lccALRecords.Clear();
            lccALPillarsList.Clear();
            lccALModulesList.Clear();
            lccALNamesList.Clear();
            lccALTitlesList.Clear();
            lccALDescriptionsList.Clear();
            lccALPreviousDescriptionsSelected.Clear();

        }
    }
}
