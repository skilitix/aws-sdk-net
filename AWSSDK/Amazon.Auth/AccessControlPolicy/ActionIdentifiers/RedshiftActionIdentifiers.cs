/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
    /// <summary>
    /// The available AWS access control policy actions for Amazon Redshift.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public class RedshiftActionIdentifiers
    {
        public static readonly ActionIdentifier AllRedshiftActions = new ActionIdentifier("redshift:*");

        public static readonly ActionIdentifier AuthorizeClusterSecurityGroupIngress = new ActionIdentifier("redshift:AuthorizeClusterSecurityGroupIngress");
        public static readonly ActionIdentifier CopyClusterSnapshot = new ActionIdentifier("redshift:CopyClusterSnapshot");
        public static readonly ActionIdentifier CreateCluster = new ActionIdentifier("redshift:CreateCluster");
        public static readonly ActionIdentifier CreateClusterParameterGroup = new ActionIdentifier("redshift:CreateClusterParameterGroup");
        public static readonly ActionIdentifier CreateClusterSecurityGroup = new ActionIdentifier("redshift:CreateClusterSecurityGroup");
        public static readonly ActionIdentifier CreateClusterSnapshot = new ActionIdentifier("redshift:CreateClusterSnapshot");
        public static readonly ActionIdentifier CreateClusterSubnetGroup = new ActionIdentifier("redshift:CreateClusterSubnetGroup");
        public static readonly ActionIdentifier DeleteCluster = new ActionIdentifier("redshift:DeleteCluster");
        public static readonly ActionIdentifier DeleteClusterParameterGroup = new ActionIdentifier("redshift:DeleteClusterParameterGroup");
        public static readonly ActionIdentifier DeleteClusterSecurityGroup = new ActionIdentifier("redshift:DeleteClusterSecurityGroup");
        public static readonly ActionIdentifier DeleteClusterSnapshot = new ActionIdentifier("redshift:DeleteClusterSnapshot");
        public static readonly ActionIdentifier DeleteClusterSubnetGroup = new ActionIdentifier("redshift:DeleteClusterSubnetGroup");
        public static readonly ActionIdentifier DescribeClusterParameterGroups = new ActionIdentifier("redshift:DescribeClusterParameterGroups");
        public static readonly ActionIdentifier DescribeClusterParameters = new ActionIdentifier("redshift:DescribeClusterParameters");
        public static readonly ActionIdentifier DescribeClusterSecurityGroups = new ActionIdentifier("redshift:DescribeClusterSecurityGroups");
        public static readonly ActionIdentifier DescribeClusterSnapshots = new ActionIdentifier("redshift:DescribeClusterSnapshots");
        public static readonly ActionIdentifier DescribeClusterSubnetGroups = new ActionIdentifier("redshift:DescribeClusterSubnetGroups");
        public static readonly ActionIdentifier DescribeClusterVersions = new ActionIdentifier("redshift:DescribeClusterVersions");
        public static readonly ActionIdentifier DescribeClusters = new ActionIdentifier("redshift:DescribeClusters");
        public static readonly ActionIdentifier DescribeDefaultClusterParameters = new ActionIdentifier("redshift:DescribeDefaultClusterParameters");
        public static readonly ActionIdentifier DescribeEvents = new ActionIdentifier("redshift:DescribeEvents");
        public static readonly ActionIdentifier DescribeOrderableClusterOptions = new ActionIdentifier("redshift:DescribeOrderableClusterOptions");
        public static readonly ActionIdentifier DescribeReservedNodeOfferings = new ActionIdentifier("redshift:DescribeReservedNodeOfferings");
        public static readonly ActionIdentifier DescribeReservedNodes = new ActionIdentifier("redshift:DescribeReservedNodes");
        public static readonly ActionIdentifier DescribeResize = new ActionIdentifier("redshift:DescribeResize");
        public static readonly ActionIdentifier ModifyCluster = new ActionIdentifier("redshift:ModifyCluster");
        public static readonly ActionIdentifier ModifyClusterParameterGroup = new ActionIdentifier("redshift:ModifyClusterParameterGroup");
        public static readonly ActionIdentifier ModifyClusterSubnetGroup = new ActionIdentifier("redshift:ModifyClusterSubnetGroup");
        public static readonly ActionIdentifier PurchaseReservedNodeOffering = new ActionIdentifier("redshift:PurchaseReservedNodeOffering");
        public static readonly ActionIdentifier RebootCluster = new ActionIdentifier("redshift:RebootCluster");
        public static readonly ActionIdentifier ResetClusterParameterGroup = new ActionIdentifier("redshift:ResetClusterParameterGroup");
        public static readonly ActionIdentifier RestoreFromClusterSnapshot = new ActionIdentifier("redshift:RestoreFromClusterSnapshot");
        public static readonly ActionIdentifier RevokeClusterSecurityGroupIngress = new ActionIdentifier("redshift:RevokeClusterSecurityGroupIngress");
    }
}
